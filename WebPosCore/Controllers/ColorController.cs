using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using WebPOSApi.Models.ColorVM;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace WebPOSApi.Controllers
{
    [Authorize]
    public class ColorController : ControllerBase
    {
        //
        ColorVM _colorVM;
        public ColorController(ColorVM colorVM)
        {
            _colorVM = colorVM;
        }

        [HttpGet]
        public dynamic GetColors()
        {
            return _colorVM.GetColors();
        }

        [HttpPost]
        public dynamic AddColor(ColorVM ColorVM)
        {
            return _colorVM.AddColor(ColorVM);
        }

        [HttpPost]
        public dynamic UpdateColor(ColorVM ColorVM)
        {
            return _colorVM.UpdateColor(ColorVM);
        }

        [HttpPost]
        public dynamic DeleteColor(ColorVM ColorVM)
        {
            return _colorVM.DeleteColor(ColorVM);
        }
	}
}