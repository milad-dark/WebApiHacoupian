using System.Threading.Tasks;
using WebApiHacoupian.Models;

namespace WebApiHacoupian.Interfaces
{
    public interface IPhoneType
    {
        /// <summary>
        /// get type phone by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<TblPhoneType> SelectById(long id);
    }
}
