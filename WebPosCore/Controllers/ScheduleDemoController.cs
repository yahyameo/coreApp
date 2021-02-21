using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebPOSApi.Models.ScheduleDemoVM;

namespace WebPOSApi.Controllers
{
    [Authorize]
    public class ScheduleDemoController : ControllerBase
    {
        // GET: ScheduleDemo
        [AllowAnonymous]
        [HttpPost]
        public bool InsertScheduleDemo(ScheduleDemoVM model)
        {
            return ScheduleDemoVM.InsertScheduleDemo(model);
        }
    }
}