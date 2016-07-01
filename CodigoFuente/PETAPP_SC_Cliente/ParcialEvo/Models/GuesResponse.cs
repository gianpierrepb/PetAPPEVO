using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ParcialEvo.Models
{
    public class GuesResponse
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class RegistrarViewModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class RegistrarMascotaViewModel
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public string Breed { get; set; }
        public string Gender { get; set; }
        public List<Gender> Genders { get; set; }
        public int SelectedGender { get; set; }
        public IEnumerable<SelectListItem> BreedList(){

                IList<SelectListItem> items = new List<SelectListItem>
                {
                    new SelectListItem { Text = "Affenpinscher", Value = "Affenpinscher"},
                    new SelectListItem { Text = "Akita", Value = "Akita"},
                    new SelectListItem { Text = "American Eskimo Dog", Value = "American Eskimo Dog"},
                    new SelectListItem { Text = "Alaskan Malamute", Value = "Alaskan Malamute"}
                };
            return items;
        }

        public static List<SelectListItem> BreedList2 = new List<SelectListItem>()
        {
            new SelectListItem() { Text = "Affenpinscher", Value = "Affenpinscher"},
            new SelectListItem() { Text = "Akita", Value = "Akita"},
            new SelectListItem() { Text = "American Eskimo Dog", Value = "American Eskimo Dog"},
            new SelectListItem() { Text = "Alaskan Malamute", Value = "Alaskan Malamute"}
            
        };
    }

    public class Gender
    {
        public int GenderId { get; set; }
        public string GenderName { get; set; }
    }
}