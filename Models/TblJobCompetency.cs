﻿using System;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblJobCompetency
    {
        public long Id { get; set; }
        public long TblJobId { get; set; }
        public long TblCompetencyId { get; set; }
        public long PreferedValue { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblCompetency TblCompetency { get; set; }
        public virtual TblJob TblJob { get; set; }
    }
}