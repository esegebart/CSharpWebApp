using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using VermeerWebApp.Models;

namespace VermeerWebApp.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 },
            new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M },
            new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M }
        };

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        public ActionResult Index()
        {
            var url = "https://api.github.com/users/{myuser}/repos";

            using (var webClient = new WebClient())
            {
                var rawJSON = string.Empty;

                try
                {
                    rawJSON = webClient.DownloadString(url);
                }
                catch (Exception) { }

                Repositories rep = JsonConvert.DeserializeObject<Repositories>(rawJSON);

                return View(rep);
            }
        }

        private ActionResult View(Repositories rep)
        {
            throw new NotImplementedException();
        }
    }
}
