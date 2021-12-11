using System.Threading.Tasks;
using WebApiHacoupian.Models;

namespace WebApiHacoupian.Interfaces
{
    public interface IFinishedGoodProduct
    {
        /// <summary>
        /// Get Barcode and Name and price a product from id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<TblFinishedGoodProduct> GetFinishedGoodProduct(long id);

        Task<TblFinishedGoodProduct> GetFinishedGoodProductByCode(string PartCode);

    }
}
