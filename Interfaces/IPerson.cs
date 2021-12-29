using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiHacoupian.Models;

namespace WebApiHacoupian.Interfaces
{
    public interface IPerson
    {
        /// <summary>
        /// Select one Person By person Code
        /// </summary>
        /// <param name="code"></param>
        /// <returns>Person</returns>
        Task<TblPerson> SelectPersonByCode(long code);
        Task<IEnumerable<TblPerson>> SelectPersonByCodeList(long code);
        Task<TblPerson> SelectLastPerson();
        /// <summary>
        /// Select All Person By Sex Code
        /// </summary>
        /// <param name="sex"></param>
        /// <param name="take"></param>
        /// <returns>List</returns>
        Task<IEnumerable<TblPerson>> SelectBySex(bool sex, int take);
        /// <summary>
        /// Select All Person By City Code
        /// برای دریافت کد شهرها باید جستجو بر روی جدول TblCity زده شود
        /// </summary>
        /// <param name="cityCode"></param>
        /// <param name="take"></param>
        /// <returns>List</returns>
        Task<IEnumerable<TblPerson>> SelectByCity(int cityCode, int take);
        /// <summary>
        /// Select All Person By MarriageDate
        /// </summary>
        /// <param name="MarriageDate"></param>
        /// <param name="take"></param>
        /// <returns>List</returns>
        Task<IEnumerable<TblPerson>> SelectByMarriage(string MarriageDate, int take);

        /// <summary>
        /// Select All Person Where BirthDate between two dates
        /// </summary>
        /// <param name="beginDate"></param>
        /// <param name="endDate"></param>
        /// <param name="take"></param>
        /// <returns>List</returns>
        Task<IEnumerable<TblPerson>> SelectByBirthDay(string beginDate, string endDate, int take);

        /// <summary>
        /// Select All Person
        /// </summary>
        /// <param name="take"></param>
        /// <returns>List</returns>
        Task<IEnumerable<TblPerson>> SelectAllPerson(int take, int id);
        /// <summary>
        /// Select a person with email and password for login
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns>one person information</returns>
        Task<TblPerson> GetPerson(string email, string password);
        /// <summary>
        /// Select a person with email and password for login
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns>Check email and pass for login and jwt</returns>
        Task<bool> Login(string email, string password);
        /// <summary>
        /// Get People by firstname and lastname
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        Task<IEnumerable<TblPerson>> SelectPersonByName(string firstName, string lastName);
        /// <summary>
        /// Get Person By id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<IEnumerable<TblPerson>> SelectPersonById(long id);
        /// <summary>
        /// Get Person By National Code
        /// </summary>
        /// <param name="nationalCode"></param>
        /// <returns></returns>
        Task<IEnumerable<TblPerson>> SelectPersonByNationalCode(string nationalCode);

        Task<bool> Insert(TblPerson person);
        Task<bool> Update(TblPerson person);

    }
}
