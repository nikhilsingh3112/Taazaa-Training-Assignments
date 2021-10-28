using EmployeeService.Models;
using Microsoft.AspNetCore.Mvc;
using EmployeeService.Repository;


namespace EmployeeService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController:ControllerBase
    {
        IEmployeeList list1;
        public EmployeeController(IEmployeeList ilist)
        {
            list1=ilist;
        }
        [HttpPost("Create")]
        public Employee CreateEmployeeData(Employee temp)
        {
            var t=list1.CreateEmployee(temp);
            if(t==1)
            {
                return temp;
            }
            return temp;
        }

        [HttpPut("Update")]
        public Employee UpdateEmployeeData(Employee temp)
        {
            var t=list1.UpdateEmployee(temp);
            if(t==1)
            {
                return temp;
            }
            return temp;
        }

        [HttpDelete("Delete")]
        public Employee DeleteEmployeeData(Employee temp)
        {
            var t=list1.DeleteEmployee(temp);
            if(t==1)
            {
                return temp;
            }
            return temp;
        }

        [HttpPut("Search")]
        public Employee SearchEmployeeData(Employee temp)
        {
            var t=list1.CreateEmployee(temp);
            if(t==1)
            {
                return temp;
            }
            return temp;
        }

        [HttpPost("Fetch")]
        public Employee FetchEmployeeData(Employee temp)
        {
            var t=list1.FetchEmployee(temp);
            if(t==1)
            {
                return temp;
            }
            return temp;
        }
        
    }
}