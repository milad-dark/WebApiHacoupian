using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiHacoupian.Interfaces;
using WebApiHacoupian.Models;

namespace WebApiHacoupian.Services
{
    public class InvoiceMasterDiscount : IInvoiceMasterDiscount
    {
        private readonly MainContext _context;

        public InvoiceMasterDiscount(MainContext context)
        {
            _context = context;
        }
        public bool Insert(List<TblInvoiceMasterDiscount> invoiceMasterDiscount)
        {
            if (invoiceMasterDiscount != null)
            {
                foreach (var item in invoiceMasterDiscount)
                {
                    _context.TblInvoiceMasterDiscounts.Add(item);
                }
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool InsertListDiscount(List<TblInvoiceMasterDiscount> invoiceMasterDiscount, long invoiceId)
        {
            foreach (TblInvoiceMasterDiscount item in invoiceMasterDiscount)
            {
                item.TblInvoiceMasterId = invoiceId;
                item.Id = 0;
                _context.TblInvoiceMasterDiscounts.Add(item);
            }
            _context.SaveChanges();

            return false;
        }

        public async Task<TblInvoiceMasterDiscount> SelectByInvoiceId(long invoiceId)
        {
            return await _context.TblInvoiceMasterDiscounts.FirstOrDefaultAsync(i=>i.TblInvoiceMasterId == invoiceId);
        }
        public async Task<IEnumerable<TblInvoiceMasterDiscount>> SelectListByInvoiceId(long invoiceId)
        {
            return await _context.TblInvoiceMasterDiscounts.Where(i => i.TblInvoiceMasterId == invoiceId).ToListAsync();
        }
    }
}
