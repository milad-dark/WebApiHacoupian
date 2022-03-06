using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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

        public async Task<IEnumerable<TblInvoiceMaster>> SelectInvoiceByPerson(string code, string fromDate, string toDate)
        {
            var invoice = await _context.TblInvoiceMasters.Where(i => i.EffectiveCode == code && i.IsDeleted == false).ToListAsync();

            return invoice.Where(i=> i.InvoiceDate.ToGregorianDate() >= fromDate.ToGregorianDate() && i.InvoiceDate.ToGregorianDate() <= toDate.ToGregorianDate()).ToList();
        }

        public async Task<TblInvoiceMaster> SelectInvoiceMasterById(long id)
        {
            return await _context.TblInvoiceMasters.FindAsync(id);
        }

        public long SelectLastNumberFactor(long placeType)
        {
            return  _context.TblInvoiceMasters.Where(i => i.TblPlaceTypeIdAsIssuer == placeType && i.IsDeleted == false).OrderByDescending(p => p.InvoiceNumber).FirstOrDefault().InvoiceNumber;
        }

        public async Task<IEnumerable<TblInvoiceMaster>> SelectReturnInvoiceByPerson(string code, string fromDate, string toDate)
        {
            var invoice = await _context.TblInvoiceMasters.Where(i => i.EffectiveCode == code && i.IsDeleted == false && i.ParentId > 0).ToListAsync();

            return invoice.Where(i => i.InvoiceDate.ToGregorianDate() >= fromDate.ToGregorianDate() && i.InvoiceDate.ToGregorianDate() <= toDate.ToGregorianDate()).ToList();
        }
    }
}
