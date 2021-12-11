using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using WebApiHacoupian.Interfaces;
using WebApiHacoupian.Models;

namespace WebApiHacoupian.Services
{
    public class ProductionOrderFinishedGoodProducts : IProductionOrderFinishedGoodProducts
    {
        private readonly MainContext _context;

        public ProductionOrderFinishedGoodProducts(MainContext context)
        {
            _context = context;
        }

        public async Task<TblProductionOrderFinishedGoodProduct> GetProductionOrderFinishedGoodProducts(long id)
        {
            return await _context.TblProductionOrderFinishedGoodProducts.FirstOrDefaultAsync(f => f.Id == id);
        }
    }
}
