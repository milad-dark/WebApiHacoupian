using System.Threading.Tasks;
using WebApiHacoupian.Models;

namespace WebApiHacoupian.Interfaces
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
