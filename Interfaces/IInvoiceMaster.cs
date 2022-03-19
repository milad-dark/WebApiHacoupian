using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiHacoupian.Models;

namespace WebApiHacoupian.Interfaces
{
    public interface IInvoiceMaster
    {
        Task<TblInvoiceMaster> SelectInvoiceMasterById(long id);
        Task<TblInvoiceMaster> SelectInvoiceMasterParentById(long id);

        Task<IEnumerable<TblInvoiceMaster>> SelectInvoiceByPerson(string code, string fromDate, string toDate);
        Task<IEnumerable<TblInvoiceMaster>> SelectReturnInvoiceByPerson(string code, string fromDate, string toDate);


        bool Insert(TblInvoiceMaster invoiceMaster);

        long SelectLastNumberFactor(long placeType);
        long SelectLastNumberFactorReturn(long placeType);

    }
}
