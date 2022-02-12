using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiHacoupian.Models;

namespace WebApiHacoupian.Interfaces
{
    public interface IInvoiceSlave
    {
        bool Insert(TblInvoiceSlave invoiceSlave);
        Task<IEnumerable<TblInvoiceSlave>> GetInvoiceSlaves(long invoiceMasterId);
    }
}
