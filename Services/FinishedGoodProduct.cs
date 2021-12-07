using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using WebApiHacoupian.Interfaces;
using WepApiHacoupian.Models;

namespace WebApiHacoupian.Services
{
    public class FinishedGoodProduct : IFinishedGoodProduct
    {
        private readonly MainContext _context;

        public FinishedGoodProduct(MainContext context)
        {
            _context = context;
        }

        public async Task<TblFinishedGoodProduct> GetFinishedGoodProduct(long id)
        {
            return await _context.TblFinishedGoodProducts.FirstOrDefaultAsync(f => f.Id == id);
        }

        public async Task<TblFinishedGoodProduct> GetFinishedGoodProductByCode(string PartCode)
        {
            return await _context.TblFinishedGoodProducts.FirstOrDefaultAsync(f => f.Code == PartCode);
        }
    }
}
