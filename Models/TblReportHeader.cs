﻿using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblReportHeader
    {
        public TblReportHeader()
        {
            TblReportDetails = new HashSet<TblReportDetail>();
        }

        public long Id { get; set; }
        public long TblReportTypeId { get; set; }
        public string ReportName { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblReportType TblReportType { get; set; }
        public virtual ICollection<TblReportDetail> TblReportDetails { get; set; }
    }
}
