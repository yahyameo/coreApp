using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using WebPOSApi.Models;
using WebPOSApi.Models.ClientVM;

namespace WebPOSApi.Controllers
{
    [Authorize]
    public class ClientController : ControllerBase
    {
        [AllowAnonymous]
        public Response Create(ClientVM model)
        {
            return ClientVM.CreateClient(model);
        }
        [AllowAnonymous]
        public Response CreateWithMobile(ClientVM model)
        {
            return ClientVM.CreateClientWithMobile(model);
        }
    }
}
