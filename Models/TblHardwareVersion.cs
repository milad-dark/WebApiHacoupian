using System;
using System.Collections.Generic;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblHardwareVersion
    {
        public TblHardwareVersion()
        {
            TblComputerHardwares = new HashSet<TblComputerHardware>();
        }

        public long Id { get; set; }
        public long TblHardwareId { get; set; }
        public long TblBrandId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblBrand TblBrand { get; set; }
        public virtual TblHardware TblHardware { get; set; }
        public virtual ICollection<TblComputerHardware> TblComputerHardwares { get; set; }
    }
}
