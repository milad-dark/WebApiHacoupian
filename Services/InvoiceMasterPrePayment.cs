using System.Threading.Tasks;
using WebApiHacoupian.Interfaces;
using WebApiHacoupian.Models;

namespace WebApiHacoupian.Services
{
    public class InvoiceMasterPrePayment : IInvoiceMasterPrePayment
    {
        private readonly MainContext _context;

        public InvoiceMasterPrePayment(MainContext context)
        {
            _context = context;
        }
        public async Task<bool> insert(TblInvoiceMasterPrepayment invoiceMasterPrepayment)
        {
            if (invoiceMasterPrepayment != null)
            {
                await _context.TblInvoiceMasterPrepayments.AddAsync(invoiceMasterPrepayment);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}
