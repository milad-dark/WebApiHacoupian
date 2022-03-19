using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiHacoupian.Models;

namespace WebApiHacoupian.Interfaces
{
    public interface IInvoiceMasterDiscount
    {
        bool Insert(List<TblInvoiceMasterDiscount> invoiceMasterDiscount);
        bool InsertListDiscount(List<TblInvoiceMasterDiscount> invoiceMasterDiscount, long invoiceId);

        Task<TblInvoiceMasterDiscount> SelectByInvoiceId(long invoiceId);
        Task<IEnumerable<TblInvoiceMasterDiscount>> SelectListByInvoiceId(long invoiceId);
    }
}
