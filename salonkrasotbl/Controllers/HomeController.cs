using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using salonkrasotbl.Models;

namespace salonkrasotbl.Controllers
{
    public class HomeController : Controller
    {
        DatabaseContext db = new DatabaseContext();
        public ActionResult Index()
        {
            IEnumerable<Services> services = db.Servicess;
            ViewBag.Services = services;
            return View();
        }
        [HttpGet]
        public ActionResult Buy(int nomer)
        {
            ViewBag.Servicesnomer = nomer;
            return View();
        }
        [HttpPost]
        public string Buy (Orders orders)
        {
            orders.vremja = DateTime.Now;
            db.Orderss.Add(orders);
            db.SaveChanges();
            return "Спасибо за покупку";
        }
        private DateTime getToday()
        {
            return DateTime.Now;
        }
    }

}