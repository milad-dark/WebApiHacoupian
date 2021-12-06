using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WepApiHacoupian.Interfaces;
using WepApiHacoupian.Models;

namespace WepApiHacoupian.Services
{
    public class Phone : IPhone
    {
        private readonly MainContext _context;
        public Phone(MainContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TblPhone>> SelectPhoneByPersonId(long personId)
        {
            return await _context.TblPhones.Where(p => p.TblPersonId == personId).ToListAsync();
        }

        public async Task<IEnumerable<TblPhone>> SelectByNumber(string phone)
        {
            return await _context.TblPhones.Where(p => p.Number == phone).ToListAsync();
        }
    }
}
