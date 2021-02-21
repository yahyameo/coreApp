using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebPOSApi.Models.DepartmentVM;

namespace WebPOSApi.Controllers
{
    [Authorize]
    public class DepartmentController : ControllerBase
    {
        [HttpGet]
        public dynamic DepartmentList(int branchId)
        {
            return DepartmentVM.DepartmentList(branchId);
        }

        [HttpGet]
        public dynamic GetDepartments(int branchId)
        {
            return DepartmentVM.GetDepartments(branchId);
        }

        [HttpPost]
        public dynamic AddDepartment(dynamic department)
        {
            return DepartmentVM.AddDepartment(department);
        }

        [HttpPost]
        public dynamic UpdateDepartment(dynamic department)
        {
            return DepartmentVM.UpdateDepartment(department);
        }

        [HttpPost]
        public dynamic DeleteDepartment(dynamic department)
        {
            return DepartmentVM.DeleteDepartment(department);
        }
    }
}
