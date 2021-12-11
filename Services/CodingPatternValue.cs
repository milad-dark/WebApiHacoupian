using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiHacoupian.Interfaces;
using WebApiHacoupian.Models;

namespace WebApiHacoupian.Services
{
    public class CodingPatternValue : ICodingPatternValue
    {
        private readonly MainContext _context;

        public CodingPatternValue(MainContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TblCodingPatternValue>> GetCodingPatternValues(List<long> ProductionMoreInfos_Ids)
        {
            return await _context.TblCodingPatternValues.Where(c => ProductionMoreInfos_Ids.Contains(c.Id)).ToListAsync();
        }
    }
}
