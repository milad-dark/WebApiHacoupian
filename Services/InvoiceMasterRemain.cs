using System.Threading.Tasks;
using WebApiHacoupian.Interfaces;
using WebApiHacoupian.Models;

namespace WebApiHacoupian.Services
{
    public class InvoiceMasterRemain : IInvoiceMasterRemain
    {
        private readonly MainContext _context;

        public InvoiceMasterRemain(MainContext context)
        {
            _context = context;
        }
        public async Task<bool> Insert(TblInvoiceMasterRemain invoiceMasterRemain)
        {
            if (invoiceMasterRemain != null)
            {
                await _context.TblInvoiceMasterRemains.AddAsync(invoiceMasterRemain);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}
