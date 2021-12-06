using System;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblCompanyPlace
    {
        public long Id { get; set; }
        public long TblCompanyId { get; set; }
        public long TblCityId { get; set; }
        public long TblPlaceTypeId { get; set; }
        public long TblDistrictId { get; set; }
        public string PostalCode { get; set; }
        public string AddressLine { get; set; }
        public string Settelment { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblCity TblCity { get; set; }
        public virtual TblCompany TblCompany { get; set; }
        public virtual TblDistrict TblDistrict { get; set; }
        public virtual TblPlaceType TblPlaceType { get; set; }
    }
}
