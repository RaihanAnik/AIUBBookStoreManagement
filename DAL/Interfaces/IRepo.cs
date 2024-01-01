using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IRepo<CLASS, ID, RETURNTYPE>
    {
        List<CLASS> Get();
        List<CLASS> GetByID(ID id);

        CLASS GetSingleById(ID id);
        RETURNTYPE Add(CLASS obj);
        bool Delete(ID id);
        RETURNTYPE Update(CLASS obj);
    }
}
