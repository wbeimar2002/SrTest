namespace SrTest.DTO
{
    public class MonthlyEmployeeDTO : EmployeeDTO
    {
        public override void CalculateSalary()
        {
            if (ContractTypeName == "MonthlySalaryEmployee")
            {
                AnnualSalary = MonthlySalary * 12;
            }
        }
    }
}
