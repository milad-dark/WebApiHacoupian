using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiHacoupian.Interfaces;
using WepApiHacoupian.Models;

namespace WebApiHacoupian.Services
{
    public class ProductionOrderRawMaterialProductsDetails : IProductionOrderRawMaterialProductsDetails
    {
        private readonly MainContext _context;

        public ProductionOrderRawMaterialProductsDetails(MainContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TblProductionOrderRawMaterialProductsDetail>> GetProductionOrderRawMaterialProductsDetails(long ProductionOrderRawMaterialProducts_Id)
        {
            return await _context.TblProductionOrderRawMaterialProductsDetails.Where(d => d.TblProductionOrderRawMaterialProductsId == ProductionOrderRawMaterialProducts_Id).ToListAsync();
        }
    }
}
