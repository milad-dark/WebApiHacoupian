using System.Threading.Tasks;
using WebApiHacoupian.Interfaces;
using WebApiHacoupian.Models;

namespace WebApiHacoupian.Services
{
    public class PhoneType : IPhoneType
    {
        private readonly MainContext _context;
        public PhoneType(MainContext context)
        {
            _context = context;
        }

        public async Task<TblPhoneType> SelectById(long id)
        {
            return await _context.TblPhoneTypes.FindAsync(id);
        }
    }
}
