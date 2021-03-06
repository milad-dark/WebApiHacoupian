using System.Threading.Tasks;
using WebApiHacoupian.Models;

namespace WebApiHacoupian.Interfaces
{
    public interface IProvince
    {
        /// <summary>
        /// get provice name by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<TblProvince> SelectProviceById(long id);
        /// <summary>
        /// Get ProviceId by Name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        Task<TblProvince> SelectProviceIdByName(string name);

    }
}
