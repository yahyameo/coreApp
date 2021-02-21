
using WebPOSApi.Models.StyleCodeVM;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace WebPOSApi.Controllers
{
    [Authorize]
    public class StyleCodeController : ControllerBase
    {

        StyleCodeVM _styleCodeVM;
        public StyleCodeController(StyleCodeVM styleCodeVM)
        {
            _styleCodeVM = styleCodeVM;
        }

        [HttpGet]
        public dynamic GetStyleCodes()
        {
            return _styleCodeVM.GetStyleCodes();
        }

        [HttpPost]
        public dynamic AddStyleCode(StyleCodeVM styleCodeVM)
        {
            return _styleCodeVM.AddStyleCode(styleCodeVM);
        }

        [HttpPost]
        public dynamic UpdateStyleCode(StyleCodeVM styleCodeVM)
        {
            return _styleCodeVM.UpdateStyleCode(styleCodeVM);
        }

        [HttpPost]
        public dynamic DeleteStyleCode(StyleCodeVM styleCodeVM)
        {
            return _styleCodeVM.DeleteStyleCode(styleCodeVM);
        }
	}
}