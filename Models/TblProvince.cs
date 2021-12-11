using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblProvince
    {
        public TblProvince()
        {
            TblCities = new HashSet<TblCity>();
            TblEmploymentRequests = new HashSet<TblEmploymentRequest>();
        }

        public long Id { get; set; }
        public long TblCountryId { get; set; }
        public string ProvinceCode { get; set; }
        public string ProvinceName { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblCountry TblCountry { get; set; }
        public virtual ICollection<TblCity> TblCities { get; set; }
        public virtual ICollection<TblEmploymentRequest> TblEmploymentRequests { get; set; }
    }
}
