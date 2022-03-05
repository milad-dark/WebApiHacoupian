using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Threading.Tasks;
using WebApiHacoupian.Interfaces;
using WebApiHacoupian.ViewModel;

namespace WebApiHacoupian.Controllers
{
    [ApiController]
    [EnableCors("myPolicy"), Route("api/[controller]/[action]")]
    public class SaleController : ControllerBase
    {
        #region Varaible
        private readonly IPerson _person;
        private readonly IInvoiceMaster _invoiceMaster;
        private readonly IInvoiceMasterDiscount _invoiceMasterDiscount;
        private readonly IInvoiceMasterPoint _invoiceMasterPoint;
        private readonly IPersonCharge _personCharge;
        private readonly ILogger<SaleController> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;
        #endregion

        public SaleController(IPerson person,
            IInvoiceMaster invoiceMaster,
            IInvoiceMasterDiscount invoiceMasterDiscount,
            IInvoiceMasterPoint invoiceMasterPoint,
            IPersonCharge personCharge,
            ILogger<SaleController> logger,
            IWebHostEnvironment webHostEnvironment)
        {
            _person = person;
            _invoiceMaster = invoiceMaster;
            _invoiceMasterDiscount = invoiceMasterDiscount;
            _invoiceMasterPoint = invoiceMasterPoint;
            _personCharge = personCharge;
            _logger = logger;
            _webHostEnvironment = webHostEnvironment;
        }
        
        [HttpPost]
        public async Task<IActionResult> RemainCharge([FromBody] SaleViewModel.Remain remain)
        {
            if (remain == null)
                return BadRequest();

            var person = await _person.SelectCustomerById(remain.user_id);
            if (person == null)
                return NotFound("مشترک یافت نشد");

            var personCharge = await _personCharge.SelectByPersonId(remain.user_id, remain.from_date, remain.to_date);
            var invoice = await _invoiceMaster.SelectInvoiceByPerson(person.FirstOrDefault().Code.ToString(), remain.from_date, remain.to_date);
            var returnInvoice = await _invoiceMaster.SelectReturnInvoiceByPerson(person.FirstOrDefault().Code.ToString(), remain.from_date, remain.to_date);

            if (invoice == null)
                return NotFound("مشترک فاقد فاکتور میباشد");

            long charge = personCharge != null ? personCharge.Sum(s => s.FromAmount) : 0;

            //sum amount invoice
            long sumDis = 0;
            long sumPoint = 0;
            foreach (var item in invoice)
            {
                var invoiceDiscount = await _invoiceMasterDiscount.SelectByInvoiceId(item.Id);
                if (invoiceDiscount != null) sumDis += invoiceDiscount.Amount;

                var invoicePoint = await _invoiceMasterPoint.SelectByInvoiceId(item.Id);
                if (invoicePoint != null) sumPoint += invoicePoint.Amount;
            }
            //sum amount return invoice
            long sumDisReturn = 0;
            long sumPointReturn = 0;
            foreach (var item in returnInvoice)
            {
                var invoiceDiscount = await _invoiceMasterDiscount.SelectByInvoiceId(item.Id);
                if (invoiceDiscount != null) sumDisReturn += invoiceDiscount.Amount;

                var invoicePoint = await _invoiceMasterPoint.SelectByInvoiceId(item.Id);
                if (invoicePoint != null) sumPointReturn += invoicePoint.Amount;
            }
            

            return Ok(new { remain = charge + sumPoint + sumPointReturn + sumDisReturn - sumDis });
        }
    }
}
