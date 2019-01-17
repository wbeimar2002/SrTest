using SrTest.DTO;
using SrTest.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace SrTest.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public  ActionResult Employee(string data)
        {

            return View();
        }

        public JsonResult LoadData(string data)
        {

            ViewBag.Message = "Employee Administration page.";
            EmployeeData employee = new EmployeeData();
            List<Employee> results = new List<Employee>(); ;
            Employee result;
            if (!String.IsNullOrEmpty(data))
            {
                EmployeeRequest employeeRequest = new EmployeeRequest();
                employeeRequest.Id = int.Parse(data);
                result =Task.Run(async() => { return await employee.GetBy(employeeRequest); }).Result;
 
                results.Add(result);
            }
            else
            {
                results = Task.Run(async () => { return await employee.GetAll(); }).Result;

                
            }
            return Json(results, JsonRequestBehavior.AllowGet);
        }


    }
}