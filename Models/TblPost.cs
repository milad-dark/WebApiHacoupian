﻿using System;
using System.Collections.Generic;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblPost
    {
        public TblPost()
        {
            TblEmployments = new HashSet<TblEmployment>();
            TblJobs = new HashSet<TblJob>();
        }

        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblEmployment> TblEmployments { get; set; }
        public virtual ICollection<TblJob> TblJobs { get; set; }
    }
}
