using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblRawMaterialProduct
    {
        public TblRawMaterialProduct()
        {
            TblFinishedGoodAlbumRawMaterialProducts = new HashSet<TblFinishedGoodAlbumRawMaterialProduct>();
            TblOrderDetails = new HashSet<TblOrderDetail>();
            TblProductAlbumDetails = new HashSet<TblProductAlbumDetail>();
            TblProductionOrderRawMaterialProducts = new HashSet<TblProductionOrderRawMaterialProduct>();
            TblRawMaterialAlbums = new HashSet<TblRawMaterialAlbum>();
            TblRawMaterialBeginPeriods = new HashSet<TblRawMaterialBeginPeriod>();
            TblRawMaterialProductCompositions = new HashSet<TblRawMaterialProductComposition>();
            TblRawMaterialProductDevelopmentTblRawMaterialProductAsConsumingMaterials = new HashSet<TblRawMaterialProductDevelopment>();
            TblRawMaterialProductDevelopmentTblRawMaterialProducts = new HashSet<TblRawMaterialProductDevelopment>();
            TblRawMaterialProductGalleries = new HashSet<TblRawMaterialProductGallery>();
            TblRawMaterialProductPrograms = new HashSet<TblRawMaterialProductProgram>();
            TblRawMaterialStockSheetItems = new HashSet<TblRawMaterialStockSheetItem>();
        }

        public long Id { get; set; }
        public long TblCompanyId { get; set; }
        public long TblCompanyIdAsSupplier { get; set; }
        public long TblCodingPatternId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string GroupCode { get; set; }
        public string GroupName { get; set; }
        public string BarCode { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblCodingPattern TblCodingPattern { get; set; }
        public virtual TblCompany TblCompany { get; set; }
        public virtual TblCompany TblCompanyIdAsSupplierNavigation { get; set; }
        public virtual ICollection<TblFinishedGoodAlbumRawMaterialProduct> TblFinishedGoodAlbumRawMaterialProducts { get; set; }
        public virtual ICollection<TblOrderDetail> TblOrderDetails { get; set; }
        public virtual ICollection<TblProductAlbumDetail> TblProductAlbumDetails { get; set; }
        public virtual ICollection<TblProductionOrderRawMaterialProduct> TblProductionOrderRawMaterialProducts { get; set; }
        public virtual ICollection<TblRawMaterialAlbum> TblRawMaterialAlbums { get; set; }
        public virtual ICollection<TblRawMaterialBeginPeriod> TblRawMaterialBeginPeriods { get; set; }
        public virtual ICollection<TblRawMaterialProductComposition> TblRawMaterialProductCompositions { get; set; }
        public virtual ICollection<TblRawMaterialProductDevelopment> TblRawMaterialProductDevelopmentTblRawMaterialProductAsConsumingMaterials { get; set; }
        public virtual ICollection<TblRawMaterialProductDevelopment> TblRawMaterialProductDevelopmentTblRawMaterialProducts { get; set; }
        public virtual ICollection<TblRawMaterialProductGallery> TblRawMaterialProductGalleries { get; set; }
        public virtual ICollection<TblRawMaterialProductProgram> TblRawMaterialProductPrograms { get; set; }
        public virtual ICollection<TblRawMaterialStockSheetItem> TblRawMaterialStockSheetItems { get; set; }
    }
}
