using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiHacoupian.Interfaces;
using WebApiHacoupian.Models;

namespace WebApiHacoupian.Services
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
