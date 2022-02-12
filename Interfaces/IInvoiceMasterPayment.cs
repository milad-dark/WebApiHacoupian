using WebApiHacoupian.Models;

namespace WebApiHacoupian.Interfaces
{
    public interface IInvoiceMasterPayment
    {
        bool Insert(TblInvoiceMasterPayment invoiceMasterPayment);
    }
}
