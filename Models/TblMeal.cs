using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiHacoupian.Models
{
    public partial class TblMeal
    {
        public TblMeal()
        {
            TblCatteringItems = new HashSet<TblCatteringItem>();
        }

        public long Id { get; set; }
        public string MealCode { get; set; }
        public string MealName { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblCatteringItem> TblCatteringItems { get; set; }
    }
}
