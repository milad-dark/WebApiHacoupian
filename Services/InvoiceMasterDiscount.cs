using System.Collections.Generic;
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
    }
}
