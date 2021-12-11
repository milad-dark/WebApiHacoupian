using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiHacoupian.Models;

namespace WebApiHacoupian.Interfaces
{
    public interface IProductionOrderMoreInfo
    {
        /// <summary>
        /// Get CodingPatternValue Ids for information order
        /// </summary>
        /// <param name="ProductionOrder_Id"></param>
        /// <returns></returns>
        Task<IEnumerable<TblProductionOrderMoreInfo>> GetProductionOrderMoreInfos(long ProductionOrder_Id);
    }
}
