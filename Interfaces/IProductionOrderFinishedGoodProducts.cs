using System.Threading.Tasks;
using WepApiHacoupian.Models;

namespace WebApiHacoupian.Interfaces
{
    public interface IProductionOrderFinishedGoodProducts
    {
        /// <summary>
        /// Get 
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        Task<TblProductionOrderFinishedGoodProduct> GetProductionOrderFinishedGoodProducts(long id);
    }
}
