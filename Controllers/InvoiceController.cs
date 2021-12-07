using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiHacoupian.Interfaces;
using WebApiHacoupian.ViewModel;
using WepApiHacoupian.Interfaces;
using WepApiHacoupian.Models;

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
        #endregion
        public InvoiceController(
            IPerson person,
            IInvoiceMaster invoiceMaster,
            IInvoiceMasterDiscount invoiceMasterDiscount,
            IInvoiceMasterPayment invoiceMasterPayment,
            IInvoiceMasterPrePayment invoiceMasterPrePayment,
            IInvoiceSlave invoiceSlave,
            IRegistrarType registrarType)
        {
            _person = person;
            _invoiceMaster = invoiceMaster;
            _invoiceMasterDiscount = invoiceMasterDiscount;
            _invoiceMasterPayment = invoiceMasterPayment;
            _invoiceMasterPrePayment = invoiceMasterPrePayment;
            _invoiceSlave = invoiceSlave;
            _registrarType = registrarType;
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] OnlineShopModel onlineShop)
        {
            //1935 placeType and person 523841 zahedi and registrar 34
            if (ModelState.IsValid)
            {
                if (onlineShop.order_items.Count == 0)
                    BadRequest("فاکتور بدون آیتم میباشد");
                if (string.IsNullOrEmpty(onlineShop.user_name) || string.IsNullOrEmpty(onlineShop.user_code))
                    BadRequest("تام مشترک یا کد مشترک خالی/صفر میباشد");
                if (onlineShop.invoice_number == 0)
                    BadRequest("فاکتور فاقد شماره میباشد");
                if (onlineShop.payment == 0)
                    BadRequest("فاکتور فاقد پرداختی میباشد");

                try
                { 
                    var invoiceMaster = new TblInvoiceMaster
                    {
                        TblCompanyIdAsOwner = onlineShop.orgin,//هاکوپیان(2) و نوراشن(907) است
                        TblCompanyIdAsReceiver = onlineShop.orgin,
                        TblCompanyIdAsIssuer = onlineShop.orgin,
                        TblPlaceTypeIdAsIssuer = 1935,//فروشگاه آنلاین
                        TblPlaceTypeIdAsReceiver = 1935,//فروشگاه آنلاین
                        TblPersonIdAsIssuer = 523841,//زاهدی
                        TblPersonIdAsReceiver = 523841,//زاهدی
                        TblInitializedTypeId = 3,//فاکتور
                        TblEffectiveTypeId = 2,//2=moshtarekin,4=moshtari adi,7=personel
                        TblInvoiceRegistrarId = 34,//فروشگاه آنلاین
                        TblInvoiceStatusId = 1,
                        TblPersonId = 523841,
                        InvoiceDate = Convert.ToDateTime(onlineShop.date).ToShamsi(),
                        InvoiceDateTime = Convert.ToDateTime(onlineShop.date),
                        InvoiceTime = Convert.ToDateTime(onlineShop.date).TimeOfDay,
                        InvoiceNumber = onlineShop.invoice_number,
                        InvoiceTo = onlineShop.user_name,
                        ParentIdFromReturn = 0,
                        ParentId = 0,
                        EffectiveCode = onlineShop.user_code,
                        Comment = "mobile",
                        TaxPercent = onlineShop.tax_percent.ToString(),
                        Tax = onlineShop.tax_price.ToString(),
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

                    return Ok($"InvoiceId: {id}");
                }
                catch (Exception ex)
                {
                    BadRequest(ex.Message);
                }
            }
            return BadRequest("داده های ارسالی اشتباه میباشد");
        }
        //Insert Order Items To TblInvoiceSlave
        private async void InsertSlaves(List<InvoiceSlave> invoiceSlave, long invoiceMasterId)
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
                        PartTax = (long)item.tax_price,
                        PartDiscount = 0,
                        Explanation = "From Online Shop",
                        IsGift = false,
                        Status = 1,
                        Guid = Guid.NewGuid(),
                        IsDeleted = false,
                        IsSent = false
                    };
                    await _invoiceSlave.Insert(slave);
                    indexItem++;
                }
            }
        }
        //Insert Payment Order To TblInvoiceMasterPayment
        private async void InsertPayment(double amount, long invoiceMasterId)
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
                await _invoiceMasterPayment.Insert(payment);
            }

        }
        //Insert Discounts Order To TblInvoiceMasterDiscount
        private async void InsertDiscounts(List<Discounts> discounts, long invoiceMasterId)
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
                await _invoiceMasterDiscount.Insert(lstDiscount);
            }
        }
    }
}
