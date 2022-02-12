using System.Collections.Generic;
using WebApiHacoupian.Models;

namespace WebApiHacoupian.Interfaces
{
    public interface IFinishedGoodStockSheetItem
    {
        bool Insert(List<TblFinishedGoodStockSheetItem> finishedGoodStockSheetItem);
    }
}
