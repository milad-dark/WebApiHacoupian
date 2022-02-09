﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiHacoupian.Interfaces;
using WebApiHacoupian.Models;

namespace WebApiHacoupian.Services
{
    public class Place : IPlace
    {
        private readonly MainContext _context;
        public Place(MainContext context)
        {
            _context = context;
        }

        public async Task<bool> Insert(TblPlace place)
        {
            if (place != null)
            {
                await _context.TblPlaces.AddAsync(place);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<IEnumerable<TblPlace>> SelectPlaceByPersonId(long personId)
        {
            return await _context.TblPlaces.Where(p => p.TblPersonId == personId && p.IsDeleted == false).ToListAsync();
        }

        public async Task<bool> Update(TblPlace place)
        {
            if (place != null)
            {
                _context.Update(place);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}
