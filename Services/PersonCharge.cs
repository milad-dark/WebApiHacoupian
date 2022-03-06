using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiHacoupian.Interfaces;
using WebApiHacoupian.Models;

namespace WebApiHacoupian.Services
{
    public class PersonCharge : IPersonCharge
    {
        private readonly MainContext _context;

        public PersonCharge(MainContext mainContext)
        {
            _context = mainContext;
        }

        public async Task<IEnumerable<TblPersonCharge>> SelectByPersonId(long personId, string fromDate, string toDate)
        {
            var person = await _context.TblPersonCharges.Where(c => c.TblDiscountTypeId == 51
            && c.TblPersonId == personId).ToListAsync();

            return  person.Where(c => c.ToDate.ToGregorianDate() >= toDate.ToGregorianDate() && c.ToDate.ToGregorianDate() <= fromDate.ToGregorianDate()).ToList();
        }
    }
}
