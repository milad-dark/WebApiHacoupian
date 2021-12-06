using System.Threading.Tasks;
using WepApiHacoupian.Interfaces;
using WepApiHacoupian.Models;

namespace WepApiHacoupian.Services
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
