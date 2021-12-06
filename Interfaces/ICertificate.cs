using System.Threading.Tasks;
using WepApiHacoupian.Models;

namespace WepApiHacoupian.Interfaces
{
    public interface ICertificate
    {
        /// <summary>
        /// Get Certificate name By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<TblCertificate> SelectCertificateById(long id);
    }
}
