using System;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblFamily
    {
        public long Id { get; set; }
        public long TblPersonId { get; set; }
        public long TblPersonIdAsFamily { get; set; }
        public long TblRelationTypeId { get; set; }
        public bool HasInsurance { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblPerson TblPerson { get; set; }
        public virtual TblPerson TblPersonIdAsFamilyNavigation { get; set; }
        public virtual TblRelationType TblRelationType { get; set; }
    }
}
