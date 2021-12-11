using System.Threading.Tasks;
using WebApiHacoupian.Models;

namespace WebApiHacoupian.Interfaces
{
    public interface IProductionOrder
    {
        /// <summary>
        /// Get Product From Number Orde
        /// </summary>
        /// <param name="Number"></param>
        /// <returns>Single Product</returns>
        Task<TblProductionOrder> productionOrder(string Number);
    }
}
