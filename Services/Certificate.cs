using System.Threading.Tasks;
using WebApiHacoupian.Interfaces;
using WebApiHacoupian.Models;

namespace WebApiHacoupian.Services
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
