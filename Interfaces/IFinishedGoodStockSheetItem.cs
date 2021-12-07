using System.Collections.Generic;
using System.Threading.Tasks;
using WepApiHacoupian.Models;

namespace WebApiHacoupian.Interfaces
{
    public interface IFinishedGoodStockSheetItem
    {
        Task<bool> Insert(List<TblFinishedGoodStockSheetItem> finishedGoodStockSheetItem);
    }
}
