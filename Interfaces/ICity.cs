using System.Collections.Generic;
using System.Threading.Tasks;
using WepApiHacoupian.Models;

namespace WepApiHacoupian.Interfaces
{
    public interface ICity
    {
        /// <summary>
        /// Get Name City By ProviceId
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<IEnumerable<TblCity>> SelectCityNameByProviceId(int id);
        /// <summary>
        /// Get City Name by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<TblCity> SelectCityNameById(long id);

        /// <summary>
        /// Get Citi Id by name
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<TblCity> SelectCityIdByCityName(string city);
    }
}
