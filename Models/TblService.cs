using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblService
    {
        public TblService()
        {
            TblServiceAttendances = new HashSet<TblServiceAttendance>();
            TblServiceEmployees = new HashSet<TblServiceEmployee>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblServiceAttendance> TblServiceAttendances { get; set; }
        public virtual ICollection<TblServiceEmployee> TblServiceEmployees { get; set; }
    }
}
