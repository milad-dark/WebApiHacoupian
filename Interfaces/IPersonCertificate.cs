using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiHacoupian.Models;

namespace WebApiHacoupian.Interfaces
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
