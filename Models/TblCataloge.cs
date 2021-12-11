using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblCataloge
    {
        public TblCataloge()
        {
            TblCatalogeItems = new HashSet<TblCatalogeItem>();
        }

        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public long Season { get; set; }
        public long PersianYear { get; set; }
        public long GregorianYear { get; set; }
        public long RatingValue { get; set; }
        public long RatingCount { get; set; }
        public byte[] CoverImage { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblCatalogeItem> TblCatalogeItems { get; set; }
    }
}
