using System.Threading.Tasks;
using WepApiHacoupian.Interfaces;
using WepApiHacoupian.Models;

namespace WepApiHacoupian.Services
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
