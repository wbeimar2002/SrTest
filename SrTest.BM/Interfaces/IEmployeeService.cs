
namespace SrTest.BM.Interfaces
{
    using SrTest.DTO;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IEmployeeService
    {
        Task<ResponsePackage<List<EmployeePayload>>> GetAll();

        Task<ResponsePackage<EmployeePayload>> GetById(EmployeeRequest request);
    }
}
