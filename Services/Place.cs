using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiHacoupian.Interfaces;
using WebApiHacoupian.Models;

namespace WebApiHacoupian.Services
{
    public class Place : IPlace
    {
        private readonly MainContext _context;
        public Place(MainContext context)
        {
            _context = context;
        }

        public bool Insert(TblPlace place)
        {
            if (place != null)
            {
                _context.TblPlaces.Add(place);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public async Task<IEnumerable<TblPlace>> SelectPlaceByPersonId(long personId)
        {
            return await _context.TblPlaces.Where(p => p.TblPersonId == personId && p.IsDeleted == false).ToListAsync();
        }

        public bool Update(TblPlace place)
        {
            if (place != null)
            {
                _context.Update(place);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
