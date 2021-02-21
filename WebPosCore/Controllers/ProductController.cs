using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebPOSApi.Models.CompanyVM;
using WebPOSApi.Models.ProductVM;

namespace WebPOSApi.Controllers
{
    [Authorize]
    public class ProductController : ControllerBase
    {
        ProductVM _productVM;
        public ProductController(ProductVM productVM)
        {
            _productVM = productVM;
        }
        [HttpGet]
        public dynamic ProductList(int branchId,int? companyId)
        {
            return _productVM.ProductList(branchId, companyId);
        }
        [HttpGet]
        public dynamic StyleCodeList()
        {
            return _productVM.StyleCodeList();
        }
        [HttpGet]
        public dynamic BrandList()
        {
            return _productVM.BrandList();
        }
        [HttpGet]
        public dynamic SizeList()
        {
            return _productVM.SizeList();
        }
        [HttpGet]
        public dynamic ColorList()
        {
            return _productVM.ColorList();
        }
        [HttpGet]
        public dynamic SeasonList()
        {
            return _productVM.SeasonList();
        }
        public dynamic GetProducts(int branchId)
        {
            return _productVM.GetProducts(branchId);
        }

        [HttpPost]
        public dynamic AddProduct(dynamic product)
        {
            return ProductVM.AddProduct(product);
        }

        [HttpPost]
        public dynamic UpdateProduct(dynamic product)
        {
            return ProductVM.UpdateProduct(product);
        }

        [HttpPost]
        public dynamic DeleteProduct(dynamic product)
        {
            return ProductVM.DeleteProduct(product);
        }
    }
}
