using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiHacoupian.Models;

namespace WebApiHacoupian.Interfaces
{
    public interface IInvoiceMasterDiscount
    {
        bool Insert(List<TblInvoiceMasterDiscount> invoiceMasterDiscount);

        Task<TblInvoiceMasterDiscount> SelectByInvoiceId(long invoiceId);
    }
}
