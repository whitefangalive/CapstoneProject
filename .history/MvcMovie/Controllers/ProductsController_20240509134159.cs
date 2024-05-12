using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ILogger<ProductsController> _logger;
        public MvcMovie.Models.User? CurrentLogginUser { get; set; }

        public ProductsController(ILogger<ProductsController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Product> products = new List<Product>();

            Product Tomato = new Product(
                productId: 1,
                name: "Tomato",
                description: "This is a fresh tomato.",
                category: "Vegetable",
                price: 0.2,
                dateGrown: "2024-05-05",
                dateHarvested: "2024-05-06",
                imageURL: "/Images/tomato.jpg");

                products.Add(Tomato);

            Product Tomato2 = new Product(
                productId: 1,
                name: "Carrot",
                description: "This is a fresh tomato.",
                category: "Vegetable",
                price: 0.2,
                dateGrown: "2024-05-05",
                dateHarvested: "2024-05-06",
                imageURL: "/Images/Carrot.jpg");

                products.Add(Tomato2);

            Product Tomato3 = new Product(
                productId: 1,
                name: "Onion",
                description: "This is a fresh tomato.",
                category: "Vegetable",
                price: 0.2,
                dateGrown: "2024-05-05",
                dateHarvested: "2024-05-06",
                imageURL: "/Images/Onion.jpg");

                products.Add(Tomato3);

            Product Tomato4 = new Product(
                productId: 1,
                name: "Potato",
                description: "This is a fresh tomato.",
                category: "Vegetable",
                price: 0.2,
                dateGrown: "2024-05-05",
                dateHarvested: "2024-05-06",
                imageURL: "/Images/Potato.jpg");

                products.Add(Tomato4);

            return View(products);
        }

        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
