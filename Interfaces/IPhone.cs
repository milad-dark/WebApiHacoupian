using System.Collections.Generic;
using System.Threading.Tasks;
using WepApiHacoupian.Models;

namespace WepApiHacoupian.Interfaces
{
    public interface IPhone
    {
        /// <summary>
        /// Get Person phone numbers from personId
        /// </summary>
        /// <param name="personId"></param>
        /// <returns></returns>
        Task<IEnumerable<TblPhone>> SelectPhoneByPersonId(long personId);
        /// <summary>
        /// Get personId by Phone number
        /// </summary>
        /// <param name="phone"></param>
        /// <returns></returns>
        Task<IEnumerable<TblPhone>> SelectByNumber(string phone);
    }
}
