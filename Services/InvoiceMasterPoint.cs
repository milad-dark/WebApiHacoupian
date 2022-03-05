using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiHacoupian.Interfaces;
using WebApiHacoupian.Models;

namespace WebApiHacoupian.Services
{
    public class InvoiceMasterPoint: IInvoiceMasterPoint
    {
        private readonly MainContext _context;

        public InvoiceMasterPoint(MainContext context)
        {
            _context = context;
        }

        public async Task<TblInvoiceMasterPoint> SelectByInvoiceId(long invoiceId)
        {
            return await _context.TblInvoiceMasterPoints.FirstOrDefaultAsync(p => p.TblInvoiceMasterId == invoiceId);
        }
    }
}
