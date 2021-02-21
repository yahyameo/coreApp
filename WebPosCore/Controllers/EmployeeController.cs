using System;
using System.Collections.Generic;
//using System.IO;
using System.Linq;


using WebPOSApi.Models.EmployeeVM;
using WebPOSApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace WebPOSApi.Controllers
{
    [Authorize]
    public class EmployeeController : ControllerBase
    {
        public dynamic GetEmployees(int branchId)
        {
            return EmployeeVM.GetEmployees(branchId);
        }
        public dynamic GetUsersList(int branchId)
        {
            return EmployeeVM.GetUsersList(branchId);
        }
        [HttpPost]
        public dynamic AddEmployee(dynamic employee)
        {
            return EmployeeVM.AddEmployee(employee);
        }

        [HttpPost]
        public dynamic UpdateEmployee(dynamic group)
        {
            return EmployeeVM.UpdateEmployee(group);
        }

        [HttpPost]
        public dynamic DeleteEmployee(dynamic group)
        {
            return EmployeeVM.DeleteEmployee(group);
        }
            [HttpPost]
        public  Boolean AddEmployeeSalary(EmployeeSalaryVM model)
        {
           return EmployeeVM.AddEmployeeSalary(model);
        }
        public  dynamic GetEmployeeSalaries(int branchId)
        {
            return EmployeeVM.GetEmployeeSalaries(branchId);
        }
   
        [HttpPost]
        public string ProfileImagePost()
        {
            //var abc=HttpContext.Current.Request.Files.Count;

            //var img = HttpContext.Current.Request.Files["uploadedFile"];
            return "/path/to/image.png";
        }

    }
}
