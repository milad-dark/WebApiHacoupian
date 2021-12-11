using WebApiHacoupian.Models;

namespace WebApiHacoupian.Interfaces
{
    public interface IRegistrarType
    {
        TblRegistrarType SelectByName(string name);
        TblRegistrarType SelectById(long id);
    }
}
