using System.Threading.Tasks;
using WebApiHacoupian.Models;

namespace WebApiHacoupian.Interfaces
{
    public interface IRawMaterialProduct
    {
        /// <summary>
        /// Get Production Code For Orders
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<TblRawMaterialProduct> GetRawMaterialProduct(long id);
        Task<TblRawMaterialProduct> GetRawMaterialProductByCode(string code);

    }
}
