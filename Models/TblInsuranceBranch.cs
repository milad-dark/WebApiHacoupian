using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblInsuranceBranch
    {
        public TblInsuranceBranch()
        {
            TblEmployments = new HashSet<TblEmployment>();
        }

        public long Id { get; set; }
        public long TblPlaceTypeId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string WorkshopCode { get; set; }
        public string WorkshopName { get; set; }
        public string Tfn { get; set; }
        public string Tin { get; set; }
        public string ZipCode { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblPlaceType TblPlaceType { get; set; }
        public virtual ICollection<TblEmployment> TblEmployments { get; set; }
    }
}
