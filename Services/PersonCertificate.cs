using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WepApiHacoupian.Interfaces;
using WepApiHacoupian.Models;

namespace WepApiHacoupian.Services
{
    public class PersonCertificate : IPersonCertificate
    {
        private readonly MainContext _context;
        public PersonCertificate(MainContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<TblPersonCertificate>> SelectCertificatesByPersonID(long personId)
        {
            return await _context.TblPersonCertificates.Where(p => p.TblPersonId == personId).ToListAsync();
        }
    }
}
