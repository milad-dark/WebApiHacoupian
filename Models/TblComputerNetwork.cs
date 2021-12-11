using System;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblComputerNetwork
    {
        public long Id { get; set; }
        public long TblComputerId { get; set; }
        public string Ipaddress { get; set; }
        public string Mask { get; set; }
        public string MacAddress { get; set; }
        public string BoxNumber { get; set; }
        public string NodeNumber { get; set; }
        public string SwitchPortNumber { get; set; }
        public string Gateway { get; set; }
        public string Dns { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblComputer TblComputer { get; set; }
    }
}
