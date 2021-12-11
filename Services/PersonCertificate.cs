using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiHacoupian.Interfaces;
using WebApiHacoupian.Models;

namespace WebApiHacoupian.Services
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
