using System.Collections.Generic;
using System.Threading.Tasks;
using WepApiHacoupian.Models;

namespace WepApiHacoupian.Interfaces
{
    public interface IPersonCertificate
    {
        /// <summary>
        /// Get All Certifications Person by personId
        /// </summary>
        /// <param name="personId"></param>
        /// <returns></returns>
        Task<IEnumerable<TblPersonCertificate>> SelectCertificatesByPersonID(long personId);
    }
}
