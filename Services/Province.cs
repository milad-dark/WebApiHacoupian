using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using WebApiHacoupian.Interfaces;
using WebApiHacoupian.Models;

namespace WebApiHacoupian.Services
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
