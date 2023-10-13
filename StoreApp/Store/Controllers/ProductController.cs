using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Entities.Models;
using Repositories;
using Repositories.Contracts;

namespace Store.Controllers
{
    public class ProductController : Controller
    {

        private readonly IRepositoryManager _manager;

        public ProductController(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public IActionResult Index()
        {
           var model =  _manager.Product.GetAllProducts(false);
           return View(model);
        }

        public IActionResult Get(int id)
        {
            //Product product = _context.Products.First(p => p.ProductId.Equals(id));
            //return View(product);
            throw new NotImplementedException();
        }
    }
}