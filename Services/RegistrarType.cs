﻿using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using WebApiHacoupian.Interfaces;
using WepApiHacoupian.Models;

namespace WebApiHacoupian.Services
{
    public class RegistrarType : IRegistrarType
    {
        private readonly MainContext _context;

        public RegistrarType(MainContext context)
        {
            _context = context;
        }

        public async Task<TblRegistrarType> SelectById(long id)
        {
            return await _context.TblRegistrarTypes.FindAsync(id);
        }

        public async Task<TblRegistrarType> SelectByName(string name)
        {
            return await _context.TblRegistrarTypes.FirstOrDefaultAsync(r => r.RegistrarTypeName == name);
        }
    }
}