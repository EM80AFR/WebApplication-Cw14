using Microsoft.AspNetCore.Mvc;
using web_app.Models;

namespace web_app.Controllers
{
    //[Route("[controller]/[action]")]

    //[Route("Product")]
    public class ProductController : Controller
    {
        public  ProductRepository Repository =new();

        public bool CheckCode (int code)
        {
            if (code>9999 || code <1000)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

       
        [Route("listmahsole")]
        public IActionResult Index()
        {
            var result = Repository.GeList();
            return View(result);
        }
        [Route("/sakhtmahsole")]

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            Repository.CreateProduct(product);
            return RedirectToAction("Index");
        }
    }
}
