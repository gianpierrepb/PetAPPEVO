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
            Session["LOGIN"] = login;
            return View("Index");
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

        public ActionResult Logout()
        {
            Session["LOGIN"] = null;
            return View("Login");
        }

        public ActionResult RegistrarUsuario()
        {
            ViewBag.Message = "Your register login page";
            return View();
        }
		
        public ActionResult RegistrarMascota()
        {
            ViewBag.Message = "Your register pet page";
            var model = GetGender();
            return View(model);
        }

        public ActionResult BuscarMascota()
        {
            ViewBag.Message = "Your searching pet page";
            return View();
        }

        public ActionResult Perfil()
        {
            ViewBag.Message = "Your profile page";
            return View();
        }


        private RegistrarMascotaViewModel GetGender()
        {
            // just a stub, in lieu of a database

            var model = new RegistrarMascotaViewModel
            {
                Genders = new List<Gender>
                {
                  new Gender
                  {
                        GenderId = 0,
                        GenderName = "Hembra"
                  },
                  new Gender
                  {
                        GenderId = 1,
                        GenderName = "Macho"
                  },
               }
            };

            return model;
        }


    }
}