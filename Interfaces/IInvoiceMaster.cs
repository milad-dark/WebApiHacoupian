using System.Threading.Tasks;
using WebApiHacoupian.Models;

namespace WebApiHacoupian.Interfaces
{
    public interface IInvoiceMaster
    {
        Task<TblInvoiceMaster> SelectInvoiceMasterById(long id);

        bool Insert(TblInvoiceMaster invoiceMaster);

        long SelectLastNumberFactor(long placeType);
    }
}
