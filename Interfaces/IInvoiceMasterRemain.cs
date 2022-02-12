using System.Threading.Tasks;
using WebApiHacoupian.Models;

namespace WebApiHacoupian.Interfaces
{
    public interface IInvoiceMasterRemain
    {
        Task<bool> Insert(TblInvoiceMasterRemain invoiceMasterRemain);
    }
}
