using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiHacoupian.Interfaces;
using WebApiHacoupian.Models;

namespace WebApiHacoupian.Services
{
    public class ProductionOrderRawMaterialProducts : IProductionOrderRawMaterialProducts
    {
        private readonly MainContext _context;
        public ProductionOrderRawMaterialProducts(MainContext context = null)
        {
            _context = context;
        }

        public async Task<IEnumerable<TblProductionOrderRawMaterialProduct>> productionOrderRawMaterialProducts(long ProductionOrder_Id)
        {
            return await _context.TblProductionOrderRawMaterialProducts.Where(m => m.TblProductionOrderId == ProductionOrder_Id).ToListAsync();
        }
    }
}
