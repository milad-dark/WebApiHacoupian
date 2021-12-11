using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblFormulaDetail
    {
        public TblFormulaDetail()
        {
            TblFormulaGroups = new HashSet<TblFormulaGroup>();
        }

        public long Id { get; set; }
        public long TblFormulaHeaderId { get; set; }
        public bool IsDynamic { get; set; }
        public bool IsComment { get; set; }
        public string GroupName { get; set; }
        public string Opeator { get; set; }
        public string Description { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblFormulaHeader TblFormulaHeader { get; set; }
        public virtual ICollection<TblFormulaGroup> TblFormulaGroups { get; set; }
    }
}
