using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using WepApiHacoupian.Interfaces;
using WepApiHacoupian.Models;

namespace WepApiHacoupian.Services
{
    public class Province : IProvince
    {
        private readonly MainContext _context;
        public Province(MainContext context)
        {
            _context = context;
        }

        public async Task<TblProvince> SelectProviceById(long id)
        {
            return await _context.TblProvinces.FindAsync(id);
        }

        public async Task<TblProvince> SelectProviceIdByName(string name)
        {
            return await _context.TblProvinces.FirstOrDefaultAsync(p => p.ProvinceName.Contains(name));

        }
    }
}
