using System.Threading.Tasks;
using WepApiHacoupian.Models;

namespace WebApiHacoupian.Interfaces
{
    public interface IProductionOrderTracking
    {
        /// <summary>
        /// Get Dates From ProductOrderId
        /// </summary>
        /// <param name="ProductionOrder_Id"></param>
        /// <returns>get last Changed Tracket</returns>
        Task<TblProductionOrderTracking> productionOrderTrackings(long ProductionOrder_Id);
    }
}
