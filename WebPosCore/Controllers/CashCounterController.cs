using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using WebPOSApi.Models;
using WebPOSApi.Models.CashCounter;

namespace WebPOSCore.Controllers
{
    [Authorize]
    public class CashCounterController : ControllerBase
    {
        [HttpGet]
        public dynamic CashCounterList(int branchId)
        {
            return CashCounterVM.CashCounterList(branchId);
        }
    }
}
