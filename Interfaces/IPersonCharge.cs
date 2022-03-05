using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiHacoupian.Models;

namespace WebApiHacoupian.Interfaces
{
    public interface IPersonCharge
    {
        Task<IEnumerable<TblPersonCharge>> SelectByPersonId(long personId,string fromDate, string toDate);
    }
}
