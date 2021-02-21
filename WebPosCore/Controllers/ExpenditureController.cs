using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using WebPOSApi.Models;

namespace WebPOSApi.Controllers
{
    [Authorize]
    public class ExpenditureController : ControllerBase
    {
        ExpenditureVM _expenditureVM;
        public ExpenditureController(ExpenditureVM expenditureVM)
        {
            _expenditureVM = expenditureVM;
        }
        [HttpPost]
        public dynamic Add(ExpenditureVM expenditure)
        {
            return _expenditureVM.Add(expenditure);
        }
        [HttpPost]
        public dynamic Update(ExpenditureVM expenditure)
        {
            return _expenditureVM.Update(expenditure);
        }
        [HttpPost]
        public dynamic Delete(Expenditure expenditure)
        {
            return _expenditureVM.Delete(expenditure);
        }
        
        [HttpGet]
        public dynamic Expenditures(int branchId,DateTime fromDate, DateTime toDate)
        {
            return _expenditureVM.Expenditures(branchId,fromDate,toDate);
        }

        [HttpGet]
        public dynamic OverAllProfit(int branchId, DateTime fromDate, DateTime toDate)
        {
            return _expenditureVM.OverAllProfit(branchId, fromDate, toDate);
        }
        [HttpGet]
        public dynamic ExpenditureList()
        {
            return _expenditureVM.ExpenditureList();
        }
    }
}
