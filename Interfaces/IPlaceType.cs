using System.Threading.Tasks;
using WepApiHacoupian.Models;

namespace WepApiHacoupian.Interfaces
{
    public interface IPlaceType
    {
        /// <summary>
        /// get person type of place by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<TblPlaceType> SelectById(long id);
    }
}
