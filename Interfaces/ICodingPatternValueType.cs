using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiHacoupian.Models;

namespace WebApiHacoupian.Interfaces
{
    public interface ICodingPatternValueType
    {
        /// <summary>
        /// Get Size,Derap,Color,Kalite,Model and other pattern
        /// </summary>
        /// <param name="CodingPatternValue_Ids"></param>
        /// <returns></returns>
        Task<IEnumerable<TblCodingPatternValueType>> GetPatternValueTypes(List<long> CodingPatternValue_Ids);
        /// <summary>
        /// Get Model Name with Product Code
        /// </summary>
        /// <param name="code"></param>
        /// <returns>Coding Name</returns>
        Task<TblCodingPatternValueType> GetPatternValueTypesByCode(string code);
        /// <summary>
        /// Get Color Name with Product Code
        /// </summary>
        /// <param name="code"></param>
        /// <returns>Coding Name</returns>
        Task<TblCodingPatternValueType> GetPatternValueColorByCode(string code);

    }
}
