using System.Threading.Tasks;
using WebApiHacoupian.Interfaces;
using WepApiHacoupian.Models;

namespace WebApiHacoupian.Services
{
    public class InvoiceMasterDiscount : IInvoiceMasterDiscount
    {
        private readonly MainContext _context;

        public InvoiceMasterDiscount(MainContext context)
        {
            _context = context;
        }
        public async Task<bool> Insert(TblInvoiceMasterDiscount invoiceMasterDiscount)
        {
            if (invoiceMasterDiscount != null)
            {
                await _context.TblInvoiceMasterDiscounts.AddAsync(invoiceMasterDiscount);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}
