using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthUp.Data.Sql.Data.DataAccess;
using HealthUp.DataModel;
using HealthUp.ServiceLayer;
using HealthUp.ViewModel;
using Microsoft.AspNetCore.Mvc;
using static HealthUp.DataModel.Product;

namespace HealthUp.Web.Controllers
{
    public class ProductController : Controller
    {
        ProductService service;
        Product productData;
        ProductDataAccess _data;
        public ProductController()
        {
            service = new ProductService();
            productData = new Product();
            _data = new ProductDataAccess();

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SendProduct(ProductViewModel productView)
        {
            var convertedData = service.ConvertViewToData(productView);
            _data.Create(convertedData);

            return View("Index");
        }
    }
}