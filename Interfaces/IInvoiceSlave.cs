using System.Collections.Generic;
using System.Threading.Tasks;
using WepApiHacoupian.Models;

namespace WebApiHacoupian.Interfaces
{
    public interface IInvoiceSlave
    {
        Task<bool> Insert(TblInvoiceSlave invoiceSlave);
        Task<IEnumerable<TblInvoiceSlave>> GetInvoiceSlaves(long invoiceMasterId);
    }
}
