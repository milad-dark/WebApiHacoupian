using System.Threading.Tasks;
using WebApiHacoupian.Interfaces;
using WebApiHacoupian.Models;

namespace WebApiHacoupian.Services
{
    public class PlaceType : IPlaceType
    {
        private readonly MainContext _context;
        public PlaceType(MainContext context)
        {
            _context = context;
        }
        public async Task<TblPlaceType> SelectById(long id)
        {
            return await _context.TblPlaceTypes.FindAsync(id);
        }
    }
}
