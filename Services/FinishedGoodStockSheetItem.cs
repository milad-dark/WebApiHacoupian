using System.Collections.Generic;
using System.Threading.Tasks;
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

        public async Task<bool> Insert(List<TblFinishedGoodStockSheetItem> finishedGoodStockSheetItem)
        {
            if (finishedGoodStockSheetItem != null)
            {
                foreach (var item in finishedGoodStockSheetItem)
                {
                    await _context.TblFinishedGoodStockSheetItems.AddAsync(item);
                }
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}
