using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using WebPOSApi.Models.BrandVM;

namespace WebPOSCore.Controllers
{
    [Authorize]
    public class BrandController :ControllerBase
    {
        BrandVM _brandVM;
        public BrandController(BrandVM brandVM)
        {
            _brandVM = brandVM;
        }

        [HttpGet]
        public dynamic GetBrands()
        {
            return _brandVM.GetBrands();
        }

        [HttpPost]
        public dynamic AddBrand(BrandVM BrandVM)
        {
            return _brandVM.AddBrand(BrandVM);
        }

        [HttpPost]
        public dynamic UpdateBrand(BrandVM BrandVM)
        {
            return _brandVM.UpdateBrand(BrandVM);
        }

        [HttpPost]
        public dynamic DeleteBrand(BrandVM BrandVM)
        {
            return _brandVM.DeleteBrand(BrandVM);
        }
	}
}