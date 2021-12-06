using System;
using System.Collections.Generic;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblIspcontract
    {
        public TblIspcontract()
        {
            TblNetworkUsages = new HashSet<TblNetworkUsage>();
        }

        public long Id { get; set; }
        public long TblCompanyId { get; set; }
        public long TblPlaceTypeId { get; set; }
        public long TblPersonId { get; set; }
        public string ContractNumber { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public string Capacity { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblCompany TblCompany { get; set; }
        public virtual TblPerson TblPerson { get; set; }
        public virtual TblPlaceType TblPlaceType { get; set; }
        public virtual ICollection<TblNetworkUsage> TblNetworkUsages { get; set; }
    }
}
