using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WepApiHacoupian.Models;

namespace WebApiHacoupian.Interfaces
{
    public interface IInvoiceSlave
    {
        Task<bool> Insert(TblInvoiceSlave invoiceSlave);
    }
}
