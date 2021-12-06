using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WepApiHacoupian.Interfaces;
using WepApiHacoupian.Models;

namespace WepApiHacoupian.Services
{
    public class Place : IPlace
    {
        private readonly MainContext _context;
        public Place(MainContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TblPlace>> SelectPlaceByPersonId(long personId)
        {
            return await _context.TblPlaces.Where(p => p.TblPersonId == personId).ToListAsync();
        }
    }
}
