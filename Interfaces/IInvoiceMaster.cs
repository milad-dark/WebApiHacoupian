using System.Threading.Tasks;
using WepApiHacoupian.Models;

namespace WebApiHacoupian.Interfaces
{
    public interface IInvoiceMaster
    {
        Task<TblInvoiceMaster> SelectInvoiceMasterById(long id);

        Task<bool> Insert(TblInvoiceMaster invoiceMaster);
    }
}
