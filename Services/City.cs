using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiHacoupian.Interfaces;
using WebApiHacoupian.Models;

namespace WebApiHacoupian.Services
{
    public class City : ICity
    {
        private readonly MainContext _context;
        public City(MainContext context)
        {
            _context = context;
        }

        public async Task<TblCity> SelectCityIdByCityName(string city)
        {
            return await _context.TblCities.FirstOrDefaultAsync(c => c.CityName.Contains(city));
        }

        public async Task<TblCity> SelectCityNameById(long id)
        {
            return await _context.TblCities.FindAsync(id);
        }

        public async Task<IEnumerable<TblCity>> SelectCityNameByProviceId(int id)
        {
            return await _context.TblCities.Where(c => c.TblProvinceId == id).ToListAsync();
        }
    }
}
