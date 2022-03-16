using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiHacoupian.Models;

namespace WebApiHacoupian.Interfaces
{
    public interface IInvoiceSlave
    {
        bool Insert(TblInvoiceSlave invoiceSlave);
        bool InsertListSlave(List<TblInvoiceSlave> invoiceSlave, long invoiceId);

        Task<IEnumerable<TblInvoiceSlave>> GetInvoiceSlaves(long invoiceMasterId);
    }
}
