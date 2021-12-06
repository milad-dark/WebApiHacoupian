using System;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblFinishedGoodProductTranslation
    {
        public long Id { get; set; }
        public long TblCompanyId { get; set; }
        public long TblCodingPatternId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public long FirstPrice { get; set; }
        public long SalesPrice { get; set; }
        public string BarCode { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }
        public string ProductGroup { get; set; }
        public string ProductComposition { get; set; }
        public string ProductPattern { get; set; }
        public string ProductModel { get; set; }
        public string ProductColor { get; set; }
        public string ProductSize { get; set; }
        public string ProductKalite { get; set; }
        public string ProductDesign { get; set; }
        public string Supplier { get; set; }
    }
}
