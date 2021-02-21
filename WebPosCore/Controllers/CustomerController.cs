using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebPOSApi.Models;
using WebPOSApi.Models.VMCustomer;

namespace WebPOSApi.Controllers
{
    [Authorize]
    public class CustomerController : ControllerBase
    {
        public List<VMCustomer> GetCustomers()
        {
           return VMCustomer.GetCustomers();
        }
    }
}