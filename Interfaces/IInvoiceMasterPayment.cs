using System.Threading.Tasks;
using WebApiHacoupian.Models;

namespace WebApiHacoupian.Interfaces
{
    public interface IInvoiceMasterPayment
    {
        bool Insert(TblInvoiceMasterPayment invoiceMasterPayment);
        Task<TblInvoiceMasterPayment> SelectByInvoiceId(long invoice_id);
    }
}
