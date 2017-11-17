using PartyInvites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {

        // GET: Home
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                return View("thanks", guestResponse);
            }
            else
            {
                return View();
            }
        }

        public ViewResult DemoExpression()
        {
            Product product = new Product()
            {
                ProductId = 1,
                Name = "Kayak",
                Description = "A Boat for one person",
                Category = "Watersports",
                Price = 275M
            };

            ViewBag.ProductCount = 1;
            ViewBag.ExpressShip = true;
            ViewBag.ApplyDiscount = false;
            ViewBag.Supplier = null;

            return View(product);
        }

        public ViewResult DemoArray()
        {
            Product[] array =
            {
                new Product{Name="Kayak",Price=275m},
                new Product{Name="Lifejacket",Price=48.95m},
                new Product{Name="Soccer ball",Price=19.50m},
                new Product{Name="Corner flag",Price=34.95m}
            };
            return View(array);
        }
    }
}