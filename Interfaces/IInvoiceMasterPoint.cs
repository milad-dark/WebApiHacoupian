using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiHacoupian.Models;

namespace WebApiHacoupian.Interfaces
{
    public interface IInvoiceMasterPoint
    {
        Task<TblInvoiceMasterPoint> SelectByInvoiceId (long invoiceId);
    }
}
