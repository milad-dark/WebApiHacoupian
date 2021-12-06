using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WepApiHacoupian.Models;

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
            if(invoiceMasterRemain != null)
            {
                await _context.TblInvoiceMasterRemains.AddAsync(invoiceMasterRemain);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}
