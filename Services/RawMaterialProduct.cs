using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using WebApiHacoupian.Interfaces;
using WepApiHacoupian.Models;

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
    }
}
