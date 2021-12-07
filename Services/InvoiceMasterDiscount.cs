using System.Collections.Generic;
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
        public async Task<bool> Insert(List<TblInvoiceMasterDiscount> invoiceMasterDiscount)
        {
            if (invoiceMasterDiscount != null)
            {
                foreach (var item in invoiceMasterDiscount)
                {
                    await _context.TblInvoiceMasterDiscounts.AddAsync(item);
                }
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}
