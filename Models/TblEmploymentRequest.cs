using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblEmploymentRequest
    {
        public TblEmploymentRequest()
        {
            TblEmploymentRequestChannels = new HashSet<TblEmploymentRequestChannel>();
            TblEmploymentRequestReasons = new HashSet<TblEmploymentRequestReason>();
            TblPersonEmploymentRequests = new HashSet<TblPersonEmploymentRequest>();
        }

        public long Id { get; set; }
        public long TbLPlaceTypeId { get; set; }
        public long TblJobId { get; set; }
        public long TblPersonId { get; set; }
        public long? TbLProvinceId { get; set; }
        public long? TblCityId { get; set; }
        public string RequestDeadline { get; set; }
        public long? AverageSalary { get; set; }
        public string Date { get; set; }
        public string IssuerComment { get; set; }
        public string Hrcomment { get; set; }
        public byte Hrstatus { get; set; }
        public byte ManagementStatus { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblPlaceType TbLPlaceType { get; set; }
        public virtual TblProvince TbLProvince { get; set; }
        public virtual TblCity TblCity { get; set; }
        public virtual TblJob TblJob { get; set; }
        public virtual TblPerson TblPerson { get; set; }
        public virtual ICollection<TblEmploymentRequestChannel> TblEmploymentRequestChannels { get; set; }
        public virtual ICollection<TblEmploymentRequestReason> TblEmploymentRequestReasons { get; set; }
        public virtual ICollection<TblPersonEmploymentRequest> TblPersonEmploymentRequests { get; set; }
    }
}
