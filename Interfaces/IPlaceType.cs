using System.Threading.Tasks;
using WebApiHacoupian.Models;

namespace WebApiHacoupian.Interfaces
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
