namespace SrTest.DM.Repositories
{
    using Newtonsoft.Json;
    using SrTest.DM.Interfaces;
    using SrTest.DM.Persistance;
    using SrTest.Tools.Support;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;

    public class EmployeeRepository: IEmployeeRepository
    {
        public async Task<IEnumerable<Employee>> GetAll()
        {
            IEnumerable<Employee> GetEmployeesResponse;
            var client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(ConstantsHelper.UrlGetEmployees);
            response.EnsureSuccessStatusCode();
            string content = await response.Content.ReadAsStringAsync();
            GetEmployeesResponse = JsonConvert.DeserializeObject<IEnumerable<Employee>>(content);
            return GetEmployeesResponse;

        }
       
    }
}
