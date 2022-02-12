using System.Collections.Generic;
using WebApiHacoupian.Interfaces;
using WebApiHacoupian.Models;

namespace WebApiHacoupian.Services
{
    public class FinishedGoodStockSheetItem : IFinishedGoodStockSheetItem
    {
        private readonly MainContext _context;

        public FinishedGoodStockSheetItem(MainContext context)
        {
            _context = context;
        }

        public bool Insert(List<TblFinishedGoodStockSheetItem> finishedGoodStockSheetItem)
        {
            if (finishedGoodStockSheetItem != null)
            {
                foreach (var item in finishedGoodStockSheetItem)
                {
                    _context.TblFinishedGoodStockSheetItems.Add(item);
                }
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
