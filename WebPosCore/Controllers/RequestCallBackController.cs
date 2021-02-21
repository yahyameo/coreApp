using Microsoft.AspNetCore.Mvc;
using WebPOSApi.Models.RequestCallBackVM;

namespace WebPOSApi.Controllers
{
    public class RequestCallBackController : ControllerBase
    {
        [HttpPost]
        public bool Add(RequestCallBackVM model)
        {
            return RequestCallBackVM.Add(model);
        }
    }
}
