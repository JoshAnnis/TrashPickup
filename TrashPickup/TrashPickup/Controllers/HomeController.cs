using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrashPickup.Views.Home;

namespace TrashPickup.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //if (User.IsInRole("member"))
            //{
            //    return View(MemberPage);
            //}
            //else if (User.IsInRole("worker"))
            //{
            //    return View(WorkerPage);
            //}
            //else
            {
                return View();
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult SelectCategory()
        {

            List<SelectListItem> items = new List<SelectListItem>();

            items.Add(new SelectListItem { Text = "DebitCard", Value = "0" });

            items.Add(new SelectListItem { Text = "CreditCard", Value = "2", Selected = true });

            items.Add(new SelectListItem { Text = "PayPal", Value = "3" });

            ViewBag.MovieType = items;

            return View();

        }
    }
}