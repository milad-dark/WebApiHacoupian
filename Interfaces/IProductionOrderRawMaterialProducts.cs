using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiHacoupian.Models;

namespace WebApiHacoupian.Interfaces
{
    public interface IProductionOrderRawMaterialProducts
    {
        /// <summary>
        /// Get Measure Count and RawMaterialProductId
        /// </summary>
        /// <param name="ProductionOrder_Id"></param>
        /// <returns>List of Product</returns>
        Task<IEnumerable<TblProductionOrderRawMaterialProduct>> productionOrderRawMaterialProducts(long ProductionOrder_Id);
    }
}
