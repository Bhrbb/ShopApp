using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopApp.Business.Abstract;
using ShopApp.UI.Models;

namespace ShopApp.UI.Controller
{
    public class HomeController : Microsoft.AspNetCore.Mvc.Controller
    {
        private IProductService _productService;
       

        public HomeController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            return View(new ProductListModel()
            {
                Products=_productService.GetAll()
            });
        }
    }
}
