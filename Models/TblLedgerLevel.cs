using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblLedgerLevel
    {
        public TblLedgerLevel()
        {
            TblLedgers = new HashSet<TblLedger>();
        }

        public long Id { get; set; }
        public long TblFinancialCycleId { get; set; }
        public long Code { get; set; }
        public string Name { get; set; }
        public byte Length { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblFinancialCycle TblFinancialCycle { get; set; }
        public virtual ICollection<TblLedger> TblLedgers { get; set; }
    }
}
