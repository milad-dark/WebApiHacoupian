using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using WebApiHacoupian.Interfaces;
using WebApiHacoupian.Models;

namespace WebApiHacoupian.Services
{
    public class RawMaterialStockSheetItem : IRawMaterialStockSheetItem
    {
        private readonly MainContext _context;

        public RawMaterialStockSheetItem(MainContext context)
        {
            _context = context;
        }

        public async Task<TblRawMaterialStockSheetItem> GetLastPriceRawProduct(long rawMaterialProductId)
        {
            return await _context.TblRawMaterialStockSheetItems.OrderBy(m => m.Id).LastOrDefaultAsync(m => m.TblRawMaterialProductId == rawMaterialProductId);
        }
    }
}
