using System.Collections.Generic;
using System.Threading.Tasks;
using WepApiHacoupian.Models;

namespace WepApiHacoupian.Interfaces
{
    public interface IPlace
    {
        /// <summary>
        /// get all address person by person id
        /// </summary>
        /// <param name="personId"></param>
        /// <returns></returns>
        Task<IEnumerable<TblPlace>> SelectPlaceByPersonId(long personId);
    }
}
