using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using clearArch.Applicaiton.Interfaces;
using clearArch.Applicaiton.ViewModals;
using Microsoft.AspNetCore.Mvc;

namespace CleanArch.API.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        private IEmployeeService _employeeServie;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeServie = employeeService;
        }
        // GET api/values
        [HttpGet]
        public ActionResult Get()
        {
            EmployeeViewModal modal = _employeeServie.GetEmployees();
            return Ok(modal);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
