﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WepApiHacoupian.Models;

namespace WebApiHacoupian.Services
{
    public interface IInvoiceMasterRemain
    {
        Task<bool> Insert(TblInvoiceMasterRemain invoiceMasterRemain);
    }
}