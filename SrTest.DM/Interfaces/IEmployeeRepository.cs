

namespace SrTest.DM.Interfaces
{
    using SrTest.DM.Persistance;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IEmployeeRepository
    {
       Task<IEnumerable<Employee>> GetAll();
    }
}
