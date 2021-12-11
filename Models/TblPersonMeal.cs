﻿using System;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblPersonMeal
    {
        public long Id { get; set; }
        public long TblPersonId { get; set; }
        public long TblCatteringItemId { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblCatteringItem TblCatteringItem { get; set; }
        public virtual TblPerson TblPerson { get; set; }
    }
}
