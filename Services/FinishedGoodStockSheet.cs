using System.Threading.Tasks;
using WebApiHacoupian.Interfaces;
using WebApiHacoupian.Models;

namespace WebApiHacoupian.Services
{
    public class FinishedGoodStockSheet : IFinishedGoodStockSheet
    {
        private readonly MainContext _context;

        public FinishedGoodStockSheet(MainContext context)
        {
            _context = context;
        }

        public async Task<bool> Insert(TblFinishedGoodStockSheet finishedGoodStockSheet)
        {
            if (finishedGoodStockSheet != null)
            {
                await _context.TblFinishedGoodStockSheets.AddAsync(finishedGoodStockSheet);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}
