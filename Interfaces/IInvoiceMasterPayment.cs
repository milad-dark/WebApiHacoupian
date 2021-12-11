using System.Threading.Tasks;
using WebApiHacoupian.Models;

namespace WebApiHacoupian.Interfaces
{
    public interface IInvoiceMasterPayment
    {
        Task<bool> Insert(TblInvoiceMasterPayment invoiceMasterPayment);
    }
}
