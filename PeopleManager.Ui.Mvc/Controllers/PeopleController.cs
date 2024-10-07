﻿using Microsoft.AspNetCore.Mvc;
using PeopleManager.Ui.Mvc.Models;

namespace PeopleManager.Ui.Mvc.Controllers
{
    public class PeopleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IList<Person> GetPeople()
        {
            return new List<Person>
            {
                new Person { FirstName = "John", LastName = "Doe", Email = "john.doe@example.com" },
                new Person { FirstName = "Jane", LastName = "Smith" }, // Email is omitted
                new Person { FirstName = "Michael", LastName = "Johnson", Email = "michael.johnson@example.com" },
                new Person { FirstName = "Emily", LastName = "Davis" }, // Email is omitted
                new Person { FirstName = "Chris", LastName = "Brown", Email = "chris.brown@example.com" },
                new Person { FirstName = "Jessica", LastName = "Wilson" }, // Email is omitted
                new Person { FirstName = "David", LastName = "Garcia", Email = "david.garcia@example.com" },
                new Person { FirstName = "Sophia", LastName = "Martinez" }, // Email is omitted
                new Person { FirstName = "Daniel", LastName = "Anderson", Email = "daniel.anderson@example.com" },
                new Person { FirstName = "Olivia", LastName = "Taylor" } // Email is omitted
            };
        }
    }
}
