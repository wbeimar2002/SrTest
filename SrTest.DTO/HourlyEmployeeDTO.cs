
namespace SrTest.DTO
{
    public class HourlyEmployeeDTO: EmployeeDTO
    {
        public override void CalculateSalary()
        {
            if (ContractTypeName == "HourlySalaryEmployee")
            {
                AnnualSalary = 120 * HourlySalary * 12;
            }
        }
    }
}
