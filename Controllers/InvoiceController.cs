using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiHacoupian.Interfaces;
using WebApiHacoupian.ViewModel;
using WepApiHacoupian.Interfaces;
using WepApiHacoupian.Models;

namespace WebApiHacoupian.Controllers
{
    [EnableCors("myPolicy"), Route("api/[controller]/[action]")]
    [ApiController]
    public class InvoiceController : Controller
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
        public InvoiceController(IPerson person, IInvoiceMaster invoiceMaster, IInvoiceMasterDiscount invoiceMasterDiscount, IInvoiceMasterPayment invoiceMasterPayment, IInvoiceMasterPrePayment invoiceMasterPrePayment, IInvoiceSlave invoiceSlave, IRegistrarType registrarType)
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
        public async Task<ActionResult> SetOrders([FromBody] OnlineShopModel onlineShop)
        {
            if (ModelState.IsValid)
            {
                
            }
            return BadRequest();
        }
        //Insert Order Items To TblInvoiceSlave
        public async void InsertSlaves(List<InvoiceSlave> invoiceSlave, long invoiceMasterId)
        {
            if (ModelState.IsValid)
            {
                if(invoiceSlave.Count > 0)
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
                            Guid = new Guid(),
                            IsDeleted = false,
                            IsSent = false
                        };
                        await _invoiceSlave.Insert(slave);
                        indexItem++;
                    }
                }
            }
        }
        //Insert Payment Order To TblInvoiceMasterPayment
        public async void InsertPayment(double amount, long invoiceMasterId)
        {
            if (ModelState.IsValid)
            {
                if (amount > 0)
                {
                        TblInvoiceMasterPayment payment = new()
                        {
                            TblInvoiceMasterId = invoiceMasterId,
                            Amount = (long)amount,
                            Explanation = "From Online Shop",                           
                            Status = 1,
                            Guid = new Guid(),
                            IsDeleted = false,
                            IsSent = false
                        };
                        await _invoiceMasterPayment.Insert(payment);                    
                }
            }
        }
        //Insert Discounts Order To TblInvoiceMasterDiscount
        public async void InsertDiscounts(List<Discounts> discounts, long invoiceMasterId)
        {
            if (ModelState.IsValid)
            {
                if (discounts.Count > 0)
                {
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
                            Guid = new Guid(),
                            IsDeleted = false,
                            IsSent = false
                        };
                        await _invoiceMasterDiscount.Insert(discount);
                    }
                }
            }
        }
    }
}
