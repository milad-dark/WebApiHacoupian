using System;
using System.Collections.Generic;

#nullable disable

namespace WepApiHacoupian.Models
{
    public partial class TblCatteringItem
    {
        public TblCatteringItem()
        {
            TblPersonMeals = new HashSet<TblPersonMeal>();
        }

        public long Id { get; set; }
        public long TblCatteringId { get; set; }
        public long TblMealId { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public string Explanation { get; set; }
        public byte Status { get; set; }
        public Guid Guid { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblCattering TblCattering { get; set; }
        public virtual TblMeal TblMeal { get; set; }
        public virtual ICollection<TblPersonMeal> TblPersonMeals { get; set; }
    }
}
