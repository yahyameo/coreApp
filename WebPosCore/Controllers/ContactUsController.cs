using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using WebPOSApi.Models.ContactUs;

namespace WebPOSApi.Controllers
{
    public class ContactUsController : ControllerBase
    {
        // GET: ContactUs
        [HttpPost]
        public bool Insert(ContactUsVM model)
        {
           return ContactUsVM.InsertContactUs(model);
        }
    }
}