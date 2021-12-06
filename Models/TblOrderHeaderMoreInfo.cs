﻿using System;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblOrderHeaderMoreInfo
    {
        public long Id { get; set; }
        public long TblOrderHeaderId { get; set; }
        public long TblCodingPatternValueId { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblOrderHeader TblOrderHeader { get; set; }
    }
}