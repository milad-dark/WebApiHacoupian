﻿using System.Threading.Tasks;
using WepApiHacoupian.Models;

namespace WebApiHacoupian.Interfaces
{
    public interface IInvoiceMasterPrePayment
    {
        Task<bool> insert(TblInvoiceMasterPrepayment invoiceMasterPrepayment);
    }
}
