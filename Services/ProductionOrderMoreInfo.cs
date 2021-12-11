using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiHacoupian.Interfaces;
using WebApiHacoupian.Models;

namespace WebApiHacoupian.Services
{
    public class ProductionOrderMoreInfo : IProductionOrderMoreInfo
    {
        private readonly MainContext _context;

        public ProductionOrderMoreInfo(MainContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TblProductionOrderMoreInfo>> GetProductionOrderMoreInfos(long ProductionOrder_Id)
        {
            return await _context.TblProductionOrderMoreInfos.Where(m => m.TblProductionOrderId == ProductionOrder_Id).ToListAsync();
        }
    }
}
