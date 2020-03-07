using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MDBinASP.NET.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Sample app for integrating MDBootstrap into ASP.NET MVC.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "You can contact me through MDBootstrap or GitHub.";

            return View();
        }

        public ActionResult Containers()
        {
            ViewBag.Title = "Containers.";

            return View();
        }

        public ActionResult Grid()
        {
            ViewBag.Title = "Grid.";

            return View();
        }

        public ActionResult Buttons()
        {
            ViewBag.Title = "Buttons.";

            return View();
        }
    }
}