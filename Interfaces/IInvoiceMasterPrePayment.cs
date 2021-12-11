using System.Threading.Tasks;
using WebApiHacoupian.Models;

namespace WebApiHacoupian.Interfaces
{
    public interface IInvoiceMasterPrePayment
    {
        Task<bool> insert(TblInvoiceMasterPrepayment invoiceMasterPrepayment);
    }
}
