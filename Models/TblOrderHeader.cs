using System;
using System.Collections.Generic;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblOrderHeader
    {
        public TblOrderHeader()
        {
            TblFinishedGoodProductFusingLabels = new HashSet<TblFinishedGoodProductFusingLabel>();
            TblFinishedGoodProductionLabels = new HashSet<TblFinishedGoodProductionLabel>();
            TblFinishedGoodStockSheetItems = new HashSet<TblFinishedGoodStockSheetItem>();
            TblOrderDetails = new HashSet<TblOrderDetail>();
            TblOrderHeaderAttachments = new HashSet<TblOrderHeaderAttachment>();
            TblOrderHeaderMoreInfos = new HashSet<TblOrderHeaderMoreInfo>();
            TblOrderHeaderOwners = new HashSet<TblOrderHeaderOwner>();
            TblRawMaterialStockSheetItems = new HashSet<TblRawMaterialStockSheetItem>();
        }

        public long Id { get; set; }
        public long TblFinishedGoodProductId { get; set; }
        public long TblCompanyId { get; set; }
        public long TblPersonAsIssuerId { get; set; }
        public long TblPlaceTypeAsIssuerId { get; set; }
        public long SheetNumber { get; set; }
        public string SheetIndex { get; set; }
        public string SheetRawIndex { get; set; }
        public string OrderDate { get; set; }
        public string DeliveryDate { get; set; }
        public string Count { get; set; }
        public string ProductionCount { get; set; }
        public string Comment { get; set; }
        public string Glue { get; set; }
        public string Liner { get; set; }
        public string Thickness { get; set; }
        public string CoatOrderNumber { get; set; }
        public string PantsOrderNumber { get; set; }
        public string CoatProductCode { get; set; }
        public string PantsProductCode { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblCompany TblCompany { get; set; }
        public virtual TblFinishedGoodProduct TblFinishedGoodProduct { get; set; }
        public virtual TblPerson TblPersonAsIssuer { get; set; }
        public virtual TblPlaceType TblPlaceTypeAsIssuer { get; set; }
        public virtual ICollection<TblFinishedGoodProductFusingLabel> TblFinishedGoodProductFusingLabels { get; set; }
        public virtual ICollection<TblFinishedGoodProductionLabel> TblFinishedGoodProductionLabels { get; set; }
        public virtual ICollection<TblFinishedGoodStockSheetItem> TblFinishedGoodStockSheetItems { get; set; }
        public virtual ICollection<TblOrderDetail> TblOrderDetails { get; set; }
        public virtual ICollection<TblOrderHeaderAttachment> TblOrderHeaderAttachments { get; set; }
        public virtual ICollection<TblOrderHeaderMoreInfo> TblOrderHeaderMoreInfos { get; set; }
        public virtual ICollection<TblOrderHeaderOwner> TblOrderHeaderOwners { get; set; }
        public virtual ICollection<TblRawMaterialStockSheetItem> TblRawMaterialStockSheetItems { get; set; }
    }
}
