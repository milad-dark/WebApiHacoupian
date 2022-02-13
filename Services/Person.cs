using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiHacoupian.Interfaces;
using WebApiHacoupian.Models;

namespace WebApiHacoupian.Services
{
    public class Person : IPerson
    {
        private readonly MainContext _context;

        public Person(MainContext context)
        {
            _context = context;
        }

        public async Task<TblPerson> GetPerson(string email, string password)
        {
            return await _context.TblPeople.FirstOrDefaultAsync(p => p.Email == email && p.Password == password);
        }

        public async Task<bool> Login(string email, string password)
        {
            return await _context.TblPeople.AnyAsync(p => p.Email == email && p.Password == password);
        }

        public async Task<IEnumerable<TblPerson>> SelectAllPerson(int take, int id)
        {
            return await _context.TblPeople.Where(p => p.Id >= id).Take(take).ToListAsync();
        }

        public async Task<IEnumerable<TblPerson>> SelectByCity(int cityCode, int take)
        {
            return await _context.TblPeople
                .Where(p => p.TblCityIdAsIssuePlace == cityCode && p.TblCityIdAsBirthPlace == cityCode).Take(take)
                .ToListAsync();
        }

        public async Task<IEnumerable<TblPerson>> SelectByMarriage(string MarriageDate, int take)
        {
            return await _context.TblPeople.Where(p => p.MarriageDate == MarriageDate).Take(take).ToListAsync();
        }

        public async Task<IEnumerable<TblPerson>> SelectBySex(bool sex, int take)
        {
            return await _context.TblPeople.Where(p => p.Sex == sex).Take(take).ToListAsync();
        }

        public async Task<TblPerson> SelectPersonByCode(long code)
        {
            return await _context.TblPeople.FirstOrDefaultAsync(p => p.Code == code && p.IsDeleted == false);
        }

        public async Task<IEnumerable<TblPerson>> SelectPersonByName(string firstName, string lastName)
        {
            return await _context.TblPeople.Where(p => p.FirstName.Contains(firstName) && p.LastName.Contains(lastName) && p.IsDeleted == false).ToListAsync();
        }

        public async Task<IEnumerable<TblPerson>> SelectPersonById(long id)
        {
            return await _context.TblPeople.Where(p => p.Id == id && p.IsDeleted == false && p.TblPersonTypeId == 100 && p.CardNumber == -1).ToListAsync();
        }

        public async Task<IEnumerable<TblPerson>> SelectPersonByNationalCode(string nationalCode)
        {
            return await _context.TblPeople.Where(p => p.NationalCode == nationalCode && p.IsDeleted == false).ToListAsync();
        }

        public async Task<IEnumerable<TblPerson>> SelectPersonByCodeList(long code)
        {
            return await _context.TblPeople.Where(p => p.Code == code && p.IsDeleted == false).ToListAsync();
        }

        public async Task<bool> Insert(TblPerson person)
        {
            if (person != null)
            {
                await _context.TblPeople.AddAsync(person);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public Task<IEnumerable<TblPerson>> SelectByBirthDay(string beginDate, string endDate, int take)
        {
            throw new NotImplementedException();
        }

        public async Task<TblPerson> SelectLastPerson()
        {
            return await _context.TblPeople.OrderByDescending(p => p.Id).FirstAsync();
        }

        public async Task<bool> Update(TblPerson person)
        {
            if (person != null)
            {
                _context.Update(person);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}