using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using WebPOSApi.Models.CompanyInvoiceVM;

namespace WebPOSApi.Controllers
{
    [Authorize]
    public class CompanyInvoiceController : ControllerBase
    {
        CompanyInvoiceVM _companyInvoiceVM;
        public CompanyInvoiceController(CompanyInvoiceVM companyInvoiceVM)
        {
            _companyInvoiceVM = companyInvoiceVM;
        }
        [HttpPost]
        public int Add(CompanyInvoiceVM companyInvoice)
        {
            return _companyInvoiceVM.Add(companyInvoice);
        }
        [HttpPost]
        public dynamic AddManualCredit(CompanyInvoiceVM companyInvoice)
        {
            return _companyInvoiceVM.AddManualCredit(companyInvoice);
        }
        [HttpGet]
        public dynamic CompanyInvoices(int branchId,DateTime fromDate, DateTime toDate)
        {
            return _companyInvoiceVM.CompanyInvoices(branchId, fromDate, toDate);
        }

        [HttpGet]
        public dynamic GetCompanyFunds(int branchId, DateTime fromDate, DateTime toDate)
        {
            return _companyInvoiceVM.GetCompanyFunds(branchId, fromDate, toDate);
        }

        [HttpGet]
        public dynamic GetCompanyFundsDetail(int branchId, int companyId, DateTime fromDate, DateTime toDate)
        {
            return _companyInvoiceVM.GetCompanyFundsDetail(branchId, companyId, fromDate, toDate);
        }
        [HttpGet]
        public dynamic GetPaymentMethodList()
        {
            return _companyInvoiceVM.GetPaymentMethodList();
        }
    }
}
