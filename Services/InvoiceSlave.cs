using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiHacoupian.Interfaces;
using WebApiHacoupian.Models;

namespace WebApiHacoupian.Services
{
    public class InvoiceSlave : IInvoiceSlave
    {
        private readonly MainContext _context;

        public InvoiceSlave(MainContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TblInvoiceSlave>> GetInvoiceSlaves(long invoiceMasterId)
        {
            return await _context.TblInvoiceSlaves.Where(c => c.TblInvoiceMasterId == invoiceMasterId && c.IsDeleted == false).ToListAsync();
        }

        public bool Insert(TblInvoiceSlave invoiceSlave)
        {
            if (invoiceSlave != null)
            {
                _context.TblInvoiceSlaves.Add(invoiceSlave);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool InsertListSlave(List<TblInvoiceSlave> invoiceSlave, long invoiceId)
        {
            foreach (TblInvoiceSlave item in invoiceSlave)
            {
                item.TblInvoiceMasterId = invoiceId;
                item.Id = 0;
                _context.TblInvoiceSlaves.Add(item);
            }
            _context.SaveChanges();
       
            return false;
        }
    }
}
