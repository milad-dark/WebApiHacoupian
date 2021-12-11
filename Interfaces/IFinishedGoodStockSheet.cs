using System.Threading.Tasks;
using WebApiHacoupian.Models;

namespace WebApiHacoupian.Interfaces
{
    public interface IFinishedGoodStockSheet
    {
        Task<bool> Insert(TblFinishedGoodStockSheet finishedGoodStockSheet);
    }
}
