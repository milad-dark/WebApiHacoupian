using System.Collections.Generic;
using WebApiHacoupian.Models;

namespace WebApiHacoupian.Interfaces
{
    public interface IInvoiceMasterDiscount
    {
        bool Insert(List<TblInvoiceMasterDiscount> invoiceMasterDiscount);
    }
}
