using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblCountry
    {
        public TblCountry()
        {
            TblLedgerInfos = new HashSet<TblLedgerInfo>();
            TblPeople = new HashSet<TblPerson>();
            TblProvinces = new HashSet<TblProvince>();
        }

        public long Id { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public string EnglishName { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblLedgerInfo> TblLedgerInfos { get; set; }
        public virtual ICollection<TblPerson> TblPeople { get; set; }
        public virtual ICollection<TblProvince> TblProvinces { get; set; }
    }
}
