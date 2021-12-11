using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiHacoupian.Models;

namespace WebApiHacoupian.Interfaces
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
