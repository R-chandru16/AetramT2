using AetramTask2.Models;
using Microsoft.AspNetCore.Mvc;

namespace AetramTask2.Controllers
{
    public class HomeController : Controller
    {
        private readonly StoreDbContext _dbContext;

        public HomeController(StoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var data = _dbContext.Products.ToList();
            return View(data);
        }
    }
}

