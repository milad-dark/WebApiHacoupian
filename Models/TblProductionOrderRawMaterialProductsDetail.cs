﻿using System;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblProductionOrderRawMaterialProductsDetail
    {
        public long Id { get; set; }
        public long TblProductionOrderRawMaterialProductsId { get; set; }
        public long TblProductionOrderFinishedGoodProductsId { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblProductionOrderFinishedGoodProduct TblProductionOrderFinishedGoodProducts { get; set; }
        public virtual TblProductionOrderRawMaterialProduct TblProductionOrderRawMaterialProducts { get; set; }
    }
}