using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiHacoupian.Models;

namespace WebApiHacoupian.Interfaces
{
    public interface IProductionOrderRawMaterialProductsDetails
    {
        /// <summary>
        /// Get List of order Size and count
        /// </summary>
        /// <param name="ProductionOrderRawMaterialProducts_Ids"></param>
        /// <returns></returns>
        Task<IEnumerable<TblProductionOrderRawMaterialProductsDetail>> GetProductionOrderRawMaterialProductsDetails(long ProductionOrderRawMaterialProducts_Id);
    }
}
