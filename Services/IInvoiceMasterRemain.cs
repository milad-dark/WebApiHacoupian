using System.Threading.Tasks;
using WebApiHacoupian.Models;

namespace WebApiHacoupian.Services
{
    public interface IInvoiceMasterRemain
    {
        Task<bool> Insert(TblInvoiceMasterRemain invoiceMasterRemain);
    }
}
