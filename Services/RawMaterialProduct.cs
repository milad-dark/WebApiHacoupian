using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using WebApiHacoupian.Interfaces;
using WebApiHacoupian.Models;

namespace WebApiHacoupian.Services
{
    public class RawMaterialProduct : IRawMaterialProduct
    {
        private readonly MainContext _context;

        public RawMaterialProduct(MainContext context)
        {
            _context = context;
        }

        public async Task<TblRawMaterialProduct> GetRawMaterialProduct(long id)
        {
            return await _context.TblRawMaterialProducts.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<TblRawMaterialProduct> GetRawMaterialProductByCode(string code)
        {
            return await _context.TblRawMaterialProducts.OrderBy(m => m.Id).LastOrDefaultAsync(x => x.Code == code);
        }
    }
}
