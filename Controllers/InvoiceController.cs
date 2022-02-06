using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiHacoupian.Interfaces;
using WebApiHacoupian.Models;
using WebApiHacoupian.ViewModel;

namespace WebApiHacoupian.Controllers
{
    [EnableCors("myPolicy"), Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        #region Variables
        private readonly IPerson _person;
        private readonly IInvoiceMaster _invoiceMaster;
        private readonly IInvoiceMasterDiscount _invoiceMasterDiscount;
        private readonly IInvoiceMasterPayment _invoiceMasterPayment;
        private readonly IInvoiceMasterPrePayment _invoiceMasterPrePayment;
        private readonly IInvoiceSlave _invoiceSlave;
        private readonly IRegistrarType _registrarType;
        private readonly IFinishedGoodStockSheet _finishedGoodStockSheet;
        private readonly IFinishedGoodStockSheetItem _finishedGoodStockSheetItem;
        private readonly IFinishedGoodProduct _finishedGoodProduct;
        private readonly ILogger<InvoiceController> _logger;
        #endregion
        public InvoiceController(
            IPerson person,
            IInvoiceMaster invoiceMaster,
            IInvoiceMasterDiscount invoiceMasterDiscount,
            IInvoiceMasterPayment invoiceMasterPayment,
            IInvoiceMasterPrePayment invoiceMasterPrePayment,
            IInvoiceSlave invoiceSlave,
            IRegistrarType registrarType,
            IFinishedGoodStockSheet finishedGoodStockSheet,
            IFinishedGoodStockSheetItem finishedGoodStockSheetItem,
            IFinishedGoodProduct finishedGoodProduct,
            ILogger<InvoiceController> logger)
        {
            _person = person;
            _invoiceMaster = invoiceMaster;
            _invoiceMasterDiscount = invoiceMasterDiscount;
            _invoiceMasterPayment = invoiceMasterPayment;
            _invoiceMasterPrePayment = invoiceMasterPrePayment;
            _invoiceSlave = invoiceSlave;
            _registrarType = registrarType;
            _finishedGoodStockSheet = finishedGoodStockSheet;
            _finishedGoodStockSheetItem = finishedGoodStockSheetItem;
            _finishedGoodProduct = finishedGoodProduct;
            _logger = logger;
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] OnlineShopModel onlineShop)
        {
            //1935 placeType and person 523841 zahedi and registrar 34
            if (ModelState.IsValid)
            {
                if (onlineShop.order_items.Count == 0)
                    return BadRequest("فاکتور بدون آیتم میباشد");
                if (string.IsNullOrEmpty(onlineShop.user_name) || string.IsNullOrEmpty(onlineShop.user_code))
                    return BadRequest("تام مشترک یا کد مشترک خالی/صفر میباشد");
                if (onlineShop.invoice_number == 0)
                    return BadRequest("فاکتور فاقد شماره میباشد");
                if (onlineShop.payment == 0)
                    return BadRequest("فاکتور فاقد پرداختی میباشد");

                try
                {
                    //Check Product list existed in DB
                    foreach (var item in onlineShop.order_items)
                    {
                        var finishedProduct = _finishedGoodProduct.GetFinishedGoodProductByCode(item.barcode).Result;
                        if (finishedProduct == null) return BadRequest(string.Format("آیتم {0} در کالاها موجود نیست", item.barcode));
                    }

                    var dateInvoice = EpouchConvertor.EpouchToDateTime(onlineShop.date);
                    var lastInvoice = _invoiceMaster.SelectLastNumberFactor(dateInvoice.ToShamsi()).Result;
                    double totalTax = 0;
                    foreach (var item in onlineShop.order_items)
                    {
                        totalTax += item.price * 0.09;
                    }
                    var invoiceMaster = new TblInvoiceMaster
                    {
                        TblCompanyIdAsOwner = onlineShop.orgin,//هاکوپیان(2) و نوراشن(907) است
                        TblCompanyIdAsReceiver = onlineShop.orgin,
                        TblCompanyIdAsIssuer = onlineShop.orgin,
                        TblPlaceTypeIdAsIssuer = 2947,//فروشگاه آنلاین (2948)
                        TblPlaceTypeIdAsReceiver = 2947,//فروشگاه آنلاین (2948)
                        TblPersonIdAsIssuer = 523841,//زاهدی
                        TblPersonIdAsReceiver = 523841,//زاهدی
                        TblInitializedTypeId = 3,//فاکتور
                        TblEffectiveTypeId = 2,//2=moshtarekin,4=moshtari adi,7=personel
                        TblInvoiceRegistrarId = 34,//فروشگاه آنلاین
                        TblInvoiceStatusId = 1,
                        TblPersonId = 523841,
                        InvoiceDate = dateInvoice.ToShamsi(),
                        InvoiceDateTime = dateInvoice,
                        InvoiceTime = dateInvoice.TimeOfDay,
                        InvoiceNumber = (lastInvoice != null) ? lastInvoice.InvoiceNumber + 1 : 1,
                        InvoiceTo = onlineShop.user_name,
                        ParentIdFromReturn = 0,
                        ParentId = 0,
                        EffectiveCode = onlineShop.user_code,
                        Comment = onlineShop.invoice_number.ToString(),
                        TaxPercent = "0.09",
                        Tax = totalTax.ToString(),
                        CanBeReturned = false,
                        Explanation = "From Online Shop",
                        Status = 1,
                        Guid = Guid.NewGuid(),
                        IsSent = false,
                        IsDeleted = false
                    };
                    await _invoiceMaster.Insert(invoiceMaster);
                    var id = invoiceMaster.Id;

                    //Insert Slave
                    InsertSlaves(onlineShop.order_items, id);
                    //Insert Discount
                    InsertDiscounts(onlineShop.discounts, id);
                    //Insert Payment
                    InsertPayment(onlineShop.payment, id);
                    //Insert Stock Sheet and Item
                    var stockId = InsertStockSheet(invoiceMaster).Result;
                    InsertStockItem(stockId, (List<TblInvoiceSlave>)_invoiceSlave.GetInvoiceSlaves(id).Result);

                    var invoiceId = new Invoice { InvoiceId = id };
                    //return Ok($"InvoiceId: {id}");
                    return Ok(invoiceId);
                }
                catch (Exception ex)
                {
                    _logger.LogError($"Insert Invoice error: {ex.Message} - {ex.InnerException}");
                    BadRequest(ex.Message);
                }
            }
            return BadRequest("داده های ارسالی اشتباه میباشد");
        }
        //Insert Order Items To TblInvoiceSlave
        private void InsertSlaves(List<InvoiceSlave> invoiceSlave, long invoiceMasterId)
        {
            try
            {
                if (invoiceSlave.Count > 0)
                {
                    int indexItem = 1;
                    foreach (var item in invoiceSlave)
                    {
                        TblInvoiceSlave slave = new()
                        {
                            TblInvoiceMasterId = invoiceMasterId,
                            PartCode = item.barcode,
                            PartCount = item.count,
                            ItemIndex = indexItem,
                            SalePrice = (long)item.price,
                            PartTax = (long)(item.price * 0.09),
                            PartDiscount = 0,
                            Explanation = "From Online Shop",
                            IsGift = false,
                            Status = 1,
                            Guid = Guid.NewGuid(),
                            IsDeleted = false,
                            IsSent = false
                        };
                        _invoiceSlave.Insert(slave);
                        indexItem++;
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Insert slave error: {ex.Message} - {ex.InnerException}");
            }
            
        }
        //Insert Payment Order To TblInvoiceMasterPayment
        private void InsertPayment(double amount, long invoiceMasterId)
        {
            try
            {
                if (amount > 0)
                {
                    TblInvoiceMasterPayment payment = new()
                    {
                        TblInvoiceMasterId = invoiceMasterId,
                        Amount = (long)amount,
                        TblPaymentTypeId = 1,
                        Explanation = "From Online Shop",
                        Status = 1,
                        Guid = Guid.NewGuid(),
                        IsDeleted = false,
                        IsSent = false
                    };
                    _invoiceMasterPayment.Insert(payment).ConfigureAwait(false);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Insert payment error: {ex.Message} - {ex.InnerException}");
            }
        }
        //Insert Discounts Order To TblInvoiceMasterDiscount
        private void InsertDiscounts(List<Discounts> discounts, long invoiceMasterId)
        {
            try
            {
                if (discounts.Count > 0)
                {
                    List<TblInvoiceMasterDiscount> lstDiscount = new List<TblInvoiceMasterDiscount>();
                    foreach (var item in discounts)
                    {
                        TblInvoiceMasterDiscount discount = new()
                        {
                            TblInvoiceMasterId = invoiceMasterId,
                            TblDiscountTypeId = item.type,
                            Amount = (long)item.price,
                            CardNumber = ";0;",
                            DiscountPercent = "0",
                            Explanation = "From Online Shop",
                            Status = 1,
                            Guid = Guid.NewGuid(),
                            IsDeleted = false,
                            IsSent = false
                        };
                        lstDiscount.Add(discount);
                    }
                    _invoiceMasterDiscount.Insert(lstDiscount).ConfigureAwait(false);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Insert discount error: {ex.Message} - {ex.InnerException}");
            }
        }
        //Insert StockSheet
        private async Task<long> InsertStockSheet(TblInvoiceMaster invoiceMaster)
        {
            string StoreCodeNew;
            switch (invoiceMaster.TblInvoiceRegistrarId.ToString())
            {

                case "2":
                    StoreCodeNew = "1953";
                    break;
                case "3":
                    StoreCodeNew = "1957";
                    break;
                case "4":
                    StoreCodeNew = "1964";
                    break;
                case "5":
                    StoreCodeNew = "1988";
                    break;
                case "6":
                    StoreCodeNew = "1968";
                    break;
                case "7":
                    StoreCodeNew = "1963";
                    break;
                case "8":
                    StoreCodeNew = "1998";
                    break;
                case "9":
                    StoreCodeNew = "1955";
                    break;
                case "10":
                    StoreCodeNew = "1983";
                    break;
                case "12":
                    StoreCodeNew = "1954";
                    break;
                case "13":
                    StoreCodeNew = "1971";
                    break;
                case "14":
                    StoreCodeNew = "1979";
                    break;
                case "15":
                    StoreCodeNew = "1994";
                    break;
                case "16":
                    StoreCodeNew = "1948";
                    break;
                case "17":
                    StoreCodeNew = "1986";
                    break;
                case "18":
                    StoreCodeNew = "1992";
                    break;
                case "19":
                    StoreCodeNew = "1973";
                    break;
                case "20":
                    StoreCodeNew = "1960";
                    break;
                case "21":
                    StoreCodeNew = "1961";
                    break;
                case "22":
                    StoreCodeNew = "1943";
                    break;
                case "23":
                    StoreCodeNew = "1996";
                    break;
                case "24":
                    StoreCodeNew = "2000";
                    break;
                case "25":
                    StoreCodeNew = "1965";
                    break;
                case "28":
                    StoreCodeNew = "1975";
                    break;
                case "29":
                    StoreCodeNew = "1970";
                    break;
                case "30":
                    StoreCodeNew = "1990";
                    break;
                case "31":
                    StoreCodeNew = "2640";
                    break;
                case "34":
                    StoreCodeNew = "2947";//2948 در دیتابیس اصلی
                    break;
                default:
                    StoreCodeNew = "1935";
                    break;
            }

            try
            {
                TblFinishedGoodStockSheet stockSheet = new()
                {
                    TblCompanyIdAsOwner = 2,
                    TblCompanyIdAsReceiver = 12336,
                    TblCompanyIdAsIssuer = null,
                    TblPlaceTypeIdAsReceiver = null,
                    TblPlaceTypeIdAsIssuer = Convert.ToInt64(StoreCodeNew),
                    TblPersonIdAsIssuer = null,
                    TblPersonIdAsReceiver = null,
                    TblFinishedGoodStockSheetTypeId = 5,
                    TblFinishedGoodStockSheetSubTypeId = 5,
                    SheetIndex = 1,
                    SheetNumber = invoiceMaster.InvoiceNumber,
                    Date = invoiceMaster.InvoiceDate,
                    Explanation = "From Online Shop",
                    Status = 0,
                    Guid = Guid.NewGuid(),
                    IsSent = false,
                    IsDeleted = false,
                };
                await _finishedGoodStockSheet.Insert(stockSheet);
                return stockSheet.Id;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Insert StockSheet error: {ex.Message} - {ex.InnerException}");
                return 0;
            }
        }
        private async void InsertStockItem(long StockId, List<TblInvoiceSlave> invoiceSlave)
        {
            try
            {
                List<TblFinishedGoodStockSheetItem> lstStockItem = new List<TblFinishedGoodStockSheetItem>();
                foreach (var item in invoiceSlave)
                {
                    var finishedProduct = _finishedGoodProduct.GetFinishedGoodProductByCode(item.PartCode).Result;
                    if (finishedProduct != null)
                    {
                        TblFinishedGoodStockSheetItem stockSheetItem = new()
                        {
                            TblFinishedGoodStockSheetId = StockId,
                            TblFinishedGoodProductId = finishedProduct.Id,
                            TblOrderHeaderId = 19902,
                            TblProductionOrderFinishedGoodProductsId = 24661,
                            Count = item.PartCount,
                            Price = item.SalePrice,
                            ParentId = "",
                            Explanation = "From Online Shop",
                            Status = 0,
                            Guid = Guid.NewGuid(),
                            IsSent = false,
                            IsDeleted = false
                        };
                        lstStockItem.Add(stockSheetItem);
                    }
                }
                await _finishedGoodStockSheetItem.Insert(lstStockItem);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Insert StockSheetItem error: {ex.Message} - {ex.InnerException}");
            }
        }
    }
}
