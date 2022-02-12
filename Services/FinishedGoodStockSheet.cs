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

        public bool Insert(TblFinishedGoodStockSheet finishedGoodStockSheet)
        {
            if (finishedGoodStockSheet != null)
            {
                _context.TblFinishedGoodStockSheets.Add(finishedGoodStockSheet);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
