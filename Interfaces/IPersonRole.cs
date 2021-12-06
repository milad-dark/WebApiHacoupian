using System.Collections.Generic;
using System.Threading.Tasks;
using WepApiHacoupian.Models;

namespace WepApiHacoupian.Interfaces
{
    public interface IPersonRole
    {
        /// <summary>
        /// Get Person Roles
        /// </summary>
        /// <param name="personId"></param>
        /// <returns></returns>
        Task<IEnumerable<TblPersonRole>> GetPersonRole(long personId);
    }
}
