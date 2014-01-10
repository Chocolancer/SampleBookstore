using HartleyMarksAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HartleyMarksAssignment.Controllers
{
    public class HomeController : Controller
    {
        public List<Category> ProductList;
        public ActionResult Index()
        {
            var newProduct1 = new Item
            {
                Id = 1,
                Title = "Waiting in Line 3D",
                Publisher = "Rajeev Basu",
                Genre = "FPS",
                Description = "It's Black Friday! Brace yourself as you spend days in advance to camp out at the local Target (pronounced Tar-jhey) and force yourself awake by punching yourself as you wait in line. Provides hours of gameplay!",
                Image = "waitinline.png",
                ReleaseDate = DateTime.Now.AddDays(-1)
            };
            var newProduct2 = new Item
            {
                Id = 2,
                Title = "Paint Drying Simulator 2014",
                Publisher = "Banpresto",
                Genre = "Simulation",
                Description = "Watch paint dry! Over 1000 colours to choose from in a variety of settings such as picket fences, bedroom walls, park benches, full houses, and more! Endless fun and excitement for the whole family!",
                Image = "paintdry.png",
                ReleaseDate = DateTime.Now
            };
            var futureProduct1 = new Item
            {
                Id = 3,
                Title = "Ikaruga",
                Publisher = "Sega",
                Genre = "Shoot 'em up",
                Image = "ikaruga.jpg",
                Description = "Explore the nature of duality while hundreds of enemies blanket you in bullets. Ikaruga boasts over 6 stages of nonstop action. Use the blue shield to block blue bullets and likewise for the red.",
                ReleaseDate = DateTime.Now.AddDays(2)
            };
            var futureProduct2 = new Item
            {
                Id = 4,
                Title = "Big Rigs: Over the Road Racing",
                Publisher = "Stellar Stone",
                Genre = "Racing",
                Image = "bigrigs.png",
                Description = "Sergey Titov revolutionizes 18-wheeler racing in this masterpiece of gaming history. Four expansive roads with five trucks to choose from. Evade cops and participate in illegal street racing.",
                ReleaseDate = DateTime.Now.AddDays(3)
            };

            var newArrivals = new List<Item> { newProduct1, newProduct2 };
            var comingSoon = new List<Item> { futureProduct1, futureProduct2 };

            ProductList = new List<Category> { new Category { Items = newArrivals, Title = "New Releases" }, new Category { Items = comingSoon, Title = "Coming Soon" } };
            return View(ProductList);
        }

        public string BuyItem(string itemTitle, string creditCardNo)
        {
            string result = "The following item has been ordered successfully: " + itemTitle;

            if (!string.IsNullOrWhiteSpace(creditCardNo))
                result += " using credit card no.: " + creditCardNo;

            return result;
        }
    }
}