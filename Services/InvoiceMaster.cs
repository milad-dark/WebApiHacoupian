using Microsoft.EntityFrameworkCore;
using System.Linq;
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

        public bool Insert(TblInvoiceMaster invoiceMaster)
        {
            if (invoiceMaster != null)
            {
                _context.TblInvoiceMasters.Add(invoiceMaster);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public async Task<TblInvoiceMaster> SelectInvoiceMasterById(long id)
        {
            return await _context.TblInvoiceMasters.FindAsync(id);
        }

        public long SelectLastNumberFactor(long placeType)
        {
            return  _context.TblInvoiceMasters.Where(i => i.TblPlaceTypeIdAsIssuer == placeType && i.IsDeleted == false).OrderByDescending(p => p.InvoiceNumber).FirstOrDefault().InvoiceNumber;
        }
    }
}
