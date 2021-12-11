using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiHacoupian.Models;

namespace WebApiHacoupian.Interfaces
{
    public interface IInvoiceMasterDiscount
    {
        Task<bool> Insert(List<TblInvoiceMasterDiscount> invoiceMasterDiscount);
    }
}
