using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using WebApiHacoupian.Interfaces;
using WebApiHacoupian.Models;

namespace WebApiHacoupian.Services
{
    public class InvoiceMasterPayment : IInvoiceMasterPayment
    {
        private readonly MainContext _context;

        public InvoiceMasterPayment(MainContext context)
        {
            _context = context;
        }
        public bool Insert(TblInvoiceMasterPayment invoiceMasterPayment)
        {
            if (invoiceMasterPayment != null)
            {
                _context.TblInvoiceMasterPayments.Add(invoiceMasterPayment);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public async Task<TblInvoiceMasterPayment> SelectByInvoiceId(long invoice_id)
        {
           return await _context.TblInvoiceMasterPayments.FirstOrDefaultAsync(i=>i.TblInvoiceMasterId == invoice_id);
        }
    }
}
