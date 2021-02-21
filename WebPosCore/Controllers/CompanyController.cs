using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using WebPOSApi.Models;
using WebPOSApi.Models.CompanyVM;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace WebPOSApi.Controllers
{
    [Authorize]
    public class CompanyController : ControllerBase
    {
        #region Product
        [HttpPost]
        public dynamic AddProducts(Product product)
        {
            var model = ProductViewModel.AddProduct(product);
            return model;
        }
        [HttpPost]
        public dynamic UpdateProducts(Product product)
        {
            var model = ProductViewModel.UpdateProductData(product);
            return model;
        }
        [HttpPost]
        public dynamic GetProductById(int? Product = 0)
        {
            var model = ProductViewModel.GetProductById(Product);
            return model;
        }
        [HttpPost]
        //[HttpGet]
        public dynamic GetProduct(int? Product = -1)
        {
            var model = ProductViewModel.GetProductList(Product);
            return model;
        }

        #endregion

        #region Group
        [HttpPost]
        public dynamic AddGroup(OgGroup group)
        {
            var model = DepartmentViewModel.AddGroup(group);
            return model;
        }

        [HttpPost]
        public dynamic UpdateGroup(OgGroup group)
        {
            var model = DepartmentViewModel.UpdateGroupData(group);
            return model;
        }

        [HttpPost]
        public dynamic GetGroup(int? GroupId = -1)
        {
            var model = DepartmentViewModel.GetGroupList(GroupId);
            return model;
        }

        [HttpPost]
        public dynamic GetGroupById(int? GroupId = 0)
        {
            var model = DepartmentViewModel.GetGroupInfoById(GroupId);
            return model;
        }

        #endregion

        #region Department
        [HttpPost]
        public dynamic AddDepartments(OgDepartment department)
        {
            var model = DepartmentViewModel.AddDepartmentName(Convert.ToString(department.Name));
            return model;
        }

        [HttpPost]
        public dynamic UpdateDepartments(OgDepartment department)
        {
            var model = DepartmentViewModel.UpdateDepartmentNameData(department);
            return model;
        }

        [HttpGet]
        public dynamic GetDepartments()
        {
            var model = DepartmentViewModel.GetDepartmentList();
            return model;
        }

        [HttpGet]
        public dynamic GetDepartmentById(int? departmentId)
        {
            var model = DepartmentViewModel.GetDepartmentById(departmentId);
            return model;
        }

        #endregion


        [HttpPost]// ab
        public dynamic AddCompany(dynamic company)
        {
            return CompanyViewModel.AddCompany(company);
        }

        [HttpGet]// ab
        public dynamic CompanyList(int branchId)
        {
            return CompanyViewModel.CompanyList(branchId);
        }

        [HttpGet]
        public dynamic GetCompany(int branchId)
        {
            return CompanyViewModel.GetCompany(branchId);
        }

        [HttpPost]
        public dynamic UpdateCompany(dynamic company)
        {
            return CompanyViewModel.UpdateCompany(company);
        }

        [HttpPost]
        public dynamic DeleteCompany(dynamic company)
        {
          return  CompanyViewModel.DeleteCompany(company);
        }
    }
}
