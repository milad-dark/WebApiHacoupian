using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiHacoupian.Interfaces;
using WebApiHacoupian.Models;

namespace WebApiHacoupian.Services
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
            return await _context.TblPhones.Where(p => p.TblPersonId == personId && p.IsDeleted == false).ToListAsync();
        }

        public async Task<IEnumerable<TblPhone>> SelectByNumber(string phone)
        {
            return await _context.TblPhones.Where(p => p.Number == phone && p.IsDeleted == false).ToListAsync();
        }

        public bool Insert(TblPhone phone)
        {
            if (phone != null)
            {
                _context.TblPhones.Add(phone);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Update(TblPhone phone)
        {
            if (phone != null)
            {
                _context.Update(phone);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public async Task<TblPhone> SelectByMobile(string phone)
        {
            return await _context.TblPhones.FirstOrDefaultAsync(p => p.Number == phone && p.TblPhoneTypeId == 32 && p.IsDeleted == false);
        }
    }
}
