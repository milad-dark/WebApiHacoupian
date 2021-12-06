using System.Threading.Tasks;
using WepApiHacoupian.Models;

namespace WepApiHacoupian.Interfaces
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
