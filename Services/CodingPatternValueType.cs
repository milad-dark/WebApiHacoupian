using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiHacoupian.Interfaces;
using WebApiHacoupian.Models;

namespace WebApiHacoupian.Services
{
    public class CodingPatternValueType : ICodingPatternValueType
    {
        private readonly MainContext _context;

        public CodingPatternValueType(MainContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TblCodingPatternValueType>> GetPatternValueTypes(List<long> CodingPatternValue_Ids)
        {
            return await _context.TblCodingPatternValueTypes.Where(c => CodingPatternValue_Ids.Contains(c.Id)).ToListAsync();
        }

        public async Task<TblCodingPatternValueType> GetPatternValueTypesByCode(string code)
        {
            return await _context.TblCodingPatternValueTypes.FirstOrDefaultAsync(
                c => c.Code == code && c.TblCodingPatternKeyId == 18 && !c.IsDeleted);
        }
        public async Task<TblCodingPatternValueType> GetPatternValueColorByCode(string code)
        {
            return await _context.TblCodingPatternValueTypes.FirstOrDefaultAsync(
                c => c.Code == code && c.TblCodingPatternKeyId == 15 && !c.IsDeleted);
        }
    }
}
