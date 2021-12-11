﻿using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblExportType
    {
        public TblExportType()
        {
            TblExports = new HashSet<TblExport>();
        }

        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblExport> TblExports { get; set; }
    }
}
