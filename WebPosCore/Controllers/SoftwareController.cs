using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebPOSApi.Models.Software;

namespace WebPOSApi.Controllers
{
    [Authorize]
    public class SoftwareController : ControllerBase
    {
        [HttpGet]
        public bool GetDatabaseBackup()
        {
            return SoftwareVM.GetDatabaseBackup();
        }
    }
}
