using System;
using System.Collections.Generic;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblRawMaterialStockSheet
    {
        public TblRawMaterialStockSheet()
        {
            TblRawMaterialStockSheetItems = new HashSet<TblRawMaterialStockSheetItem>();
        }

        public long Id { get; set; }
        public long TblCompanyIdAsOwner { get; set; }
        public long? TblPersonIdAsReceiver { get; set; }
        public long? TblCompanyIdAsReceiver { get; set; }
        public long? TblPlaceTypeIdAsReceiver { get; set; }
        public long? TblPersonIdAsIssuer { get; set; }
        public long? TblCompanyIdAsIssuer { get; set; }
        public long? TblPlaceTypeIdAsIssuer { get; set; }
        public long TblRawMaterialStockSheetTypeId { get; set; }
        public long TblRawMaterialStockSheetSubTypeId { get; set; }
        public long SheetNumber { get; set; }
        public long SheetIndex { get; set; }
        public string Date { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblCompany TblCompanyIdAsIssuerNavigation { get; set; }
        public virtual TblCompany TblCompanyIdAsOwnerNavigation { get; set; }
        public virtual TblCompany TblCompanyIdAsReceiverNavigation { get; set; }
        public virtual TblPerson TblPersonIdAsIssuerNavigation { get; set; }
        public virtual TblPerson TblPersonIdAsReceiverNavigation { get; set; }
        public virtual TblPlaceType TblPlaceTypeIdAsIssuerNavigation { get; set; }
        public virtual TblPlaceType TblPlaceTypeIdAsReceiverNavigation { get; set; }
        public virtual TblRawMaterialStockSheetSubType TblRawMaterialStockSheetSubType { get; set; }
        public virtual TblRawMaterialStockSheetType TblRawMaterialStockSheetType { get; set; }
        public virtual ICollection<TblRawMaterialStockSheetItem> TblRawMaterialStockSheetItems { get; set; }
    }
}
