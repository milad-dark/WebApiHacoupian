﻿using System;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblFinishedGoodProductionLabelComposition
    {
        public long Id { get; set; }
        public long TblFinishedGoodProductionLabelId { get; set; }
        public long TblRawMaterialProductCompositionTypeId { get; set; }
        public long Percent { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblFinishedGoodProductionLabel TblFinishedGoodProductionLabel { get; set; }
        public virtual TblRawMaterialProductCompositionType TblRawMaterialProductCompositionType { get; set; }
    }
}