using Business.Abstract;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        IEmployeeService _EmployeeService;
        public EmployeesController(IEmployeeService EmployeeService)
        {
            _EmployeeService = EmployeeService;

        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_EmployeeService.GetAll());
        }

        [HttpPost("add")]
        public void Add(Employee Employee)
        {
            if(ModelState.IsValid)
            {
                _EmployeeService.Add(Employee);
            }
            
            
        }

        [HttpGet("getEmployeebyname/{name}")]
        public IActionResult GetEmployeesByName(string name)
        {
            var result=_EmployeeService.GetEmployeesByName(name);
            return Ok(result);
        }

        [HttpPut("update/{Employeeid}")]
        public void Update(int Employeeid,[FromBody] Employee Employee)
        {
            Employee.EmployeeId = Employeeid;
            if (ModelState.IsValid)
            {
                _EmployeeService.Update(Employee);
            }
        }

        [HttpPost("delete")]
        public void Delete(Employee Employee)
        {
            _EmployeeService.Delete(Employee);
        }

    }
}
