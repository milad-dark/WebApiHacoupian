using System;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblCost
    {
        public long Id { get; set; }
        public long TblInvoiceRegistrarId { get; set; }
        public string Date { get; set; }
        public long? Cost { get; set; }
        public long? Bank { get; set; }
        public long? Maskancard { get; set; }
        public long? MeliCheck { get; set; }
        public long? Receipt { get; set; }
        public long? Parsiancard { get; set; }
        public long? SaderatCheck { get; set; }
        public long? CashDraft { get; set; }
        public long? CheckDraft { get; set; }
        public TimeSpan? Time { get; set; }
        public DateTime InsertDateTime { get; set; }
        public long? PersoanlCheque { get; set; }
        public string Explanation { get; set; }
        public byte? Status { get; set; }
        public Guid? Guid { get; set; }
        public bool? IsSent { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual TblRegistrarType TblInvoiceRegistrar { get; set; }
    }
}
