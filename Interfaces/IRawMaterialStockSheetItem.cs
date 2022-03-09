using System.Threading.Tasks;
using WebApiHacoupian.Models;

namespace WebApiHacoupian.Interfaces
{
    public interface IRawMaterialStockSheetItem
    {
        Task<TblRawMaterialStockSheetItem> GetLastPriceRawProduct(long rawMaterialProductId);
    }
}
