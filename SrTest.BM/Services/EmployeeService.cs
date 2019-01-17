using AutoMapper;
using SrTest.BM.Interfaces;
using SrTest.DM.Interfaces;
using SrTest.DM.Persistance;
using SrTest.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
namespace SrTest.BM.Services
{


    public class EmployeeService: IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;
        public EmployeeService(IEmployeeRepository employeeRepository, IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }
        public async Task<ResponsePackage<List<EmployeePayload>>> GetAll()
        {
            var result = new ResponsePackage<List<EmployeePayload>>();
            var employees = await GetEmployees();
            result.Result = employees;
            return result;
        }
        public async Task<ResponsePackage<EmployeePayload>> GetById(EmployeeRequest request)
        {
            var result = new ResponsePackage<EmployeePayload>();
            var employees = await GetEmployees();
            var employee = employees.Where(t => t.Id == request.Id).FirstOrDefault();
            if (employee != null)
                result.Result = employee;
            else
                result.Message = $"Not Employee Found for Id: { request.Id }";
            return result;
        }

        private async Task<List<EmployeePayload>> GetEmployees()
        {
            var result = new List<EmployeePayload>();
            var employees = await _employeeRepository.GetAll();

            var hourly = employees.Where(t => t.ContractTypeName == "HourlySalaryEmployee").ToList();
            var montly = employees.Where(t => t.ContractTypeName == "MonthlySalaryEmployee").ToList();

            var x = _mapper.Map<IEnumerable<Employee>, IEnumerable<HourlyEmployeeDTO>>(hourly).ToList();

            var y = _mapper.Map<IEnumerable<Employee>, IEnumerable<MonthlyEmployeeDTO>>(montly).ToList();

            
            x.ForEach(t => t.CalculateSalary());
            y.ForEach(t => t.CalculateSalary());

            result.AddRange(_mapper.Map<IEnumerable<HourlyEmployeeDTO>, IEnumerable<EmployeePayload>>(x).ToList());
            result.AddRange(_mapper.Map<IEnumerable<MonthlyEmployeeDTO>, IEnumerable<EmployeePayload>>(y).ToList());

            return result;
        }

      
    }
}
