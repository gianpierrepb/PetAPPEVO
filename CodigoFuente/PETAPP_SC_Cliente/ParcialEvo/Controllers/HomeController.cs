using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ParcialEvo.Models;

namespace ParcialEvo.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        

        [HttpPost]
        public ViewResult Index(LoginViewModel login)
        {
            //login.Nombre = "Hans";
            return View("Index", login);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }


        public ActionResult Login()
        {
            ViewBag.Message = "Your login page.";

            return View();
        }

        public ActionResult RegistrarUsuario()
        {
            ViewBag.Message = "Your register login page";
            return View();
        }
    }
}