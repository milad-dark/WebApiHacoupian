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
        public async Task<bool> Insert(TblInvoiceMasterPayment invoiceMasterPayment)
        {
            if (invoiceMasterPayment != null)
            {
                await _context.TblInvoiceMasterPayments.AddAsync(invoiceMasterPayment);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}
