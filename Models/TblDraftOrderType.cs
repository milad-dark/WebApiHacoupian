﻿using System;
using System.Collections.Generic;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblDraftOrderType
    {
        public TblDraftOrderType()
        {
            TblDraftOrders = new HashSet<TblDraftOrder>();
        }

        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblDraftOrder> TblDraftOrders { get; set; }
    }
}
