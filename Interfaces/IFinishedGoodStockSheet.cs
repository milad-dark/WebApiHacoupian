using System.Threading.Tasks;
using WepApiHacoupian.Models;

namespace WebApiHacoupian.Interfaces
{
    public interface IFinishedGoodStockSheet
    {
        Task<bool> Insert(TblFinishedGoodStockSheet finishedGoodStockSheet);
    }
}
