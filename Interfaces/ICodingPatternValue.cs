using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiHacoupian.Models;

namespace WebApiHacoupian.Interfaces
{
    public interface ICodingPatternValue
    {
        /// <summary>
        /// Get List of Coding Pattern Value for Get Types
        /// </summary>
        /// <param name="ProductionMoreInfos_Ids"></param>
        /// <returns></returns>
        Task<IEnumerable<TblCodingPatternValue>> GetCodingPatternValues(List<long> ProductionMoreInfos_Ids);
    }
}
