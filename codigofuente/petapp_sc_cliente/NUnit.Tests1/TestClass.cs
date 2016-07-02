using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParcialEvo.Controllers;
using System.IO;
using System.Net;
using ParcialEvo.Models;
using System.Web.Mvc;

namespace NUnit.Tests1
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void LoginTest()
        {
            WebRequest request = WebRequest.Create("https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js");
            request.Method = "POST";
            WebResponse response = request.GetResponse();

            AccountController controller = new AccountController();
            var model = new LoginViewModel() { UserName = "a", Password = "123" };
            var result = controller.Login(model, "") as ViewResult;
           
            Assert.AreEqual("Index", result.ViewName);
            
        }


        [Test]
        public void RegisterUserTest()
        {
            WebRequest request = WebRequest.Create("http://ec2-52-40-149-74.us-west-2.compute.amazonaws.com/api/create/user");
            request.Method = "POST";
            WebResponse response = request.GetResponse();

            AccountController controller = new AccountController();
            var model = new RegisterViewModel() { UserName = "roberto", Password = "123" };
            var result = controller.Register(model) as ViewResult;
           
            Assert.AreEqual("Index", result.ViewName);
            
        }



        [Test]
        public void RegisterPetTest()
        {
            WebRequest request = WebRequest.Create("http://ec2-52-40-149-74.us-west-2.compute.amazonaws.com/api/create/dogs");
            request.Method = "POST";
            WebResponse response = request.GetResponse();

            AccountController controller = new AccountController();
            var model = new RegistrarMascotaViewModel() { Name = "perro", Age = "2", Breed="Snouzer", Gender="0"};
            var result = controller.RegisterPet(model) as ViewResult;
           
            Assert.AreEqual("Index", result.ViewName);
            
        }

    }
}
