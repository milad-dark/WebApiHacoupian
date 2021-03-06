using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiHacoupian.Models;

namespace WebApiHacoupian.Interfaces
{
    public interface IPlace
    {
        /// <summary>
        /// get all address person by person id
        /// </summary>
        /// <param name="personId"></param>
        /// <returns></returns>
        Task<IEnumerable<TblPlace>> SelectPlaceByPersonId(long personId);

        bool Insert(TblPlace place);
        bool Update(TblPlace place);
    }
}
