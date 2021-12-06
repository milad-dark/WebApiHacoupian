﻿using System;
using System.Collections.Generic;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblFormula
    {
        public TblFormula()
        {
            TblEmployments = new HashSet<TblEmployment>();
        }

        public long Id { get; set; }
        public long? ParentId { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string Formula { get; set; }
        public string PropertyType { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblEmployment> TblEmployments { get; set; }
    }
}
