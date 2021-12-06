using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WepApiHacoupian.Interfaces;
using WepApiHacoupian.Models;

namespace WepApiHacoupian.Services
{
    public class PersonRole : IPersonRole
    {
        private readonly MainContext _context;

        public PersonRole(MainContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TblPersonRole>> GetPersonRole(long personId)
        {
            return await _context.TblPersonRoles.Where(p => p.TblPersonId == personId).ToListAsync();
        }
    }
}
