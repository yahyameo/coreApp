
using WebPOSApi.Models.SizeVM;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebPOSApi.Controllers
{
    [Authorize]
    public class SizeController : ControllerBase
    {
        //[HttpGet]
        SizeVM _sizeVM;
        public SizeController(SizeVM sizeVM)
        {
            _sizeVM = sizeVM;
        }

        [HttpGet]
        public dynamic GetSizes()
        {
            return _sizeVM.GetSizes();
        }

        [HttpPost]
        public dynamic AddSize(SizeVM SizeVM)
        {
            return _sizeVM.AddSize(SizeVM);
        }

        [HttpPost]
        public dynamic UpdateSize(SizeVM sizeVM)
        {
            return _sizeVM.UpdateSize(sizeVM);
        }

        [HttpPost]
        public dynamic DeleteSize(SizeVM SizeVM)
        {
            return _sizeVM.DeleteSize(SizeVM);
        }
	}
}