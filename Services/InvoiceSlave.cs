﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiHacoupian.Interfaces;
using WepApiHacoupian.Models;

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
            return await _context.TblInvoiceSlaves.Where(c => c.TblInvoiceMasterId == invoiceMasterId).ToListAsync();
        }

        public async Task<bool> Insert(TblInvoiceSlave invoiceSlave)
        {
            if (invoiceSlave != null)
            {
                await _context.TblInvoiceSlaves.AddAsync(invoiceSlave);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}
