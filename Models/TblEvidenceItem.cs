using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblEvidenceItem
    {
        public TblEvidenceItem()
        {
            TblEvidenceItemCurrencies = new HashSet<TblEvidenceItemCurrency>();
            TblTaxInfos = new HashSet<TblTaxInfo>();
        }

        public long Id { get; set; }
        public long TblEvidenceId { get; set; }
        public long TblLedgerId { get; set; }
        public string Comment { get; set; }
        public long Amount { get; set; }
        public int Quantity { get; set; }
        public bool IsDebit { get; set; }
        public string AccountCode { get; set; }
        public long BatchNumber { get; set; }
        public string Description { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblEvidence TblEvidence { get; set; }
        public virtual TblLedger TblLedger { get; set; }
        public virtual ICollection<TblEvidenceItemCurrency> TblEvidenceItemCurrencies { get; set; }
        public virtual ICollection<TblTaxInfo> TblTaxInfos { get; set; }
    }
}
