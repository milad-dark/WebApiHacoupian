using System.Threading.Tasks;
using WepApiHacoupian.Interfaces;
using WepApiHacoupian.Models;

namespace WepApiHacoupian.Services
{
    public class Certificate : ICertificate
    {
        private readonly MainContext _context;
        public Certificate(MainContext context)
        {
            _context = context;
        }
        public async Task<TblCertificate> SelectCertificateById(long id)
        {
            return await _context.TblCertificates.FindAsync(id);
        }
    }
}
