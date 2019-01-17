using SrTest.BM.Interfaces;
using SrTest.DTO;
using Swashbuckle.Swagger.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace SrTest.API.Controllers
{
    public class EmployeeController : ApiController
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [SwaggerOperation("Employee/GetAll")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.BadRequest)]
        [HttpGet]
        [Route("GetAll")]
        public async Task<HttpResponseMessage> GetAll()
        {
            var result = await _employeeService.GetAll();
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

        [SwaggerOperation("Employee/GetById")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.BadRequest)]
        [HttpGet]
        [Route("GetById")]
        public async Task<HttpResponseMessage> GetById([FromUri] EmployeeRequest request)
        {
            if (request == null)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }

            var result = await _employeeService.GetById(request);
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

       
    }
}
