using System.Threading.Tasks;
using WebApiHacoupian.Models;

namespace WebApiHacoupian.Interfaces
{
    public interface IInvoiceMaster
    {
        Task<TblInvoiceMaster> SelectInvoiceMasterById(long id);

        Task<bool> Insert(TblInvoiceMaster invoiceMaster);

        Task<TblInvoiceMaster> SelectLastNumberFactor(long placeType);
    }
}
