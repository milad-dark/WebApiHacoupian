using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblComputer
    {
        public TblComputer()
        {
            TblComputerHardwares = new HashSet<TblComputerHardware>();
            TblComputerNetworks = new HashSet<TblComputerNetwork>();
            TblComputerSoftwares = new HashSet<TblComputerSoftware>();
            TblPersonSystems = new HashSet<TblPersonSystem>();
        }

        public long Id { get; set; }
        public int Type { get; set; }
        public string Code { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblComputerHardware> TblComputerHardwares { get; set; }
        public virtual ICollection<TblComputerNetwork> TblComputerNetworks { get; set; }
        public virtual ICollection<TblComputerSoftware> TblComputerSoftwares { get; set; }
        public virtual ICollection<TblPersonSystem> TblPersonSystems { get; set; }
    }
}
