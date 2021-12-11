using System.Threading.Tasks;
using WebApiHacoupian.Interfaces;
using WebApiHacoupian.Models;

namespace WebApiHacoupian.Services
{
    public class InvoiceMaster : IInvoiceMaster
    {
        private readonly MainContext _context;

        public InvoiceMaster(MainContext context)
        {
            _context = context;
        }

        public async Task<bool> Insert(TblInvoiceMaster invoiceMaster)
        {
            if (invoiceMaster != null)
            {
                await _context.TblInvoiceMasters.AddAsync(invoiceMaster);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<TblInvoiceMaster> SelectInvoiceMasterById(long id)
        {
            return await _context.TblInvoiceMasters.FindAsync(id);
        }
    }
}
