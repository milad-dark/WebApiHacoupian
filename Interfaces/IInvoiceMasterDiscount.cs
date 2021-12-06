using System.Threading.Tasks;
using WepApiHacoupian.Models;

namespace WebApiHacoupian.Interfaces
{
    public interface IInvoiceMasterDiscount
    {
        Task<bool> Insert(TblInvoiceMasterDiscount invoiceMasterDiscount);
    }
}
