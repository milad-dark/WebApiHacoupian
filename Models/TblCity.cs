using System;
using System.Collections.Generic;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblCity
    {
        public TblCity()
        {
            TblCompanyPlaces = new HashSet<TblCompanyPlace>();
            TblDistricts = new HashSet<TblDistrict>();
            TblEmploymentRequests = new HashSet<TblEmploymentRequest>();
            TblPersonTblCityIdAsBirthPlaceNavigations = new HashSet<TblPerson>();
            TblPersonTblCityIdAsIssuePlaceNavigations = new HashSet<TblPerson>();
            TblPlaces = new HashSet<TblPlace>();
        }

        public long Id { get; set; }
        public long TblProvinceId { get; set; }
        public string CityCode { get; set; }
        public string CityName { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblProvince TblProvince { get; set; }
        public virtual ICollection<TblCompanyPlace> TblCompanyPlaces { get; set; }
        public virtual ICollection<TblDistrict> TblDistricts { get; set; }
        public virtual ICollection<TblEmploymentRequest> TblEmploymentRequests { get; set; }
        public virtual ICollection<TblPerson> TblPersonTblCityIdAsBirthPlaceNavigations { get; set; }
        public virtual ICollection<TblPerson> TblPersonTblCityIdAsIssuePlaceNavigations { get; set; }
        public virtual ICollection<TblPlace> TblPlaces { get; set; }
    }
}
