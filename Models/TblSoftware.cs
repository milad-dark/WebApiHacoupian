using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblSoftware
    {
        public TblSoftware()
        {
            TblJobSoftwares = new HashSet<TblJobSoftware>();
            TblSoftwareVersions = new HashSet<TblSoftwareVersion>();
        }

        public long Id { get; set; }
        public long TblSoftwareTypeId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblSoftwareType TblSoftwareType { get; set; }
        public virtual ICollection<TblJobSoftware> TblJobSoftwares { get; set; }
        public virtual ICollection<TblSoftwareVersion> TblSoftwareVersions { get; set; }
    }
}
