using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using WebApiHacoupian.Interfaces;
using WepApiHacoupian.Models;

namespace WebApiHacoupian.Services
{
    public class ProductionOrderTracking : IProductionOrderTracking
    {
        private readonly MainContext _context;
        public ProductionOrderTracking(MainContext context)
        {
            _context = context;
        }

        public async Task<TblProductionOrderTracking> productionOrderTrackings(long ProductionOrder_Id)
        {
            return await _context.TblProductionOrderTrackings.OrderBy(t => t.Id).LastOrDefaultAsync(t => t.TblProductionOrderId == ProductionOrder_Id);
        }
    }
}
