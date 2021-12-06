﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiHacoupian.Interfaces;
using WepApiHacoupian.Models;

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
    }
}