using System;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblExport
    {
        public long Id { get; set; }
        public long TblPersonId { get; set; }
        public long TblExportTypeId { get; set; }
        public string ExportNumber { get; set; }
        public bool IsEnabled { get; set; }
        public string ExportDate { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblExportType TblExportType { get; set; }
        public virtual TblPerson TblPerson { get; set; }
    }
}
