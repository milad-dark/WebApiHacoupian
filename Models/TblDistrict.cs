using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblDistrict
    {
        public TblDistrict()
        {
            TblCompanyPlaces = new HashSet<TblCompanyPlace>();
            TblPlaces = new HashSet<TblPlace>();
        }

        public long Id { get; set; }
        public long? TblCityId { get; set; }
        public string DistrictCode { get; set; }
        public string DistrictName { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Explanation { get; set; }
        public byte? Status { get; set; }
        public Guid? Guid { get; set; }
        public bool? IsSent { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual TblCity TblCity { get; set; }
        public virtual ICollection<TblCompanyPlace> TblCompanyPlaces { get; set; }
        public virtual ICollection<TblPlace> TblPlaces { get; set; }
    }
}
