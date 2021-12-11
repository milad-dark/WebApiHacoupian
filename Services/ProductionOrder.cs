using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using WebApiHacoupian.Interfaces;
using WebApiHacoupian.Models;

namespace WebApiHacoupian.Services
{
    public class ProductionOrder : IProductionOrder
    {
        private readonly MainContext _context;
        public ProductionOrder(MainContext context)
        {
            _context = context;
        }
        public async Task<TblProductionOrder> productionOrder(string Number)
        {
            return await _context.TblProductionOrders.SingleOrDefaultAsync(p => p.Number == Convert.ToDouble(Number));
        }
    }
}
