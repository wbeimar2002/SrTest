using Newtonsoft.Json;
using SrTest.DTO;
using SrTest.Tools.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace SrTest.Web.Models
{
    public class EmployeeData
    {
        public async Task<List<Employee>> GetAll()
        {
            List<Employee> GetEmployeesResponse;
            var client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(ConstantsHelper.UrlGetInternalEmployees + "GetAll");
            response.EnsureSuccessStatusCode();
            string content = await response.Content.ReadAsStringAsync();
            GetEmployeesResponse = JsonConvert.DeserializeObject<ResponsePackage<IEnumerable<Employee>>>(content).Result.ToList();
            return GetEmployeesResponse;
        }

        public async Task<Employee> GetBy(EmployeeRequest employeeRequest)
        {
            Employee GetEmployeesResponse;
            var client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(ConstantsHelper.UrlGetInternalEmployees + "GetById?request.id="+employeeRequest.Id);
            response.EnsureSuccessStatusCode();
            string content = await response.Content.ReadAsStringAsync();
            GetEmployeesResponse = JsonConvert.DeserializeObject<ResponsePackage<Employee>>(content).Result;
            return GetEmployeesResponse;
        }
    }
}