﻿using Microsoft.AspNetCore.Mvc;
using PeopleManager.Ui.Mvc.Core;

namespace PeopleManager.Ui.Mvc.Controllers
{
    public class PeopleController : Controller
    {
        private readonly PeopleManagerDbContext _peopleManagerDbContext;

        public PeopleController(PeopleManagerDbContext peopleManagerDbContext)
        {
            _peopleManagerDbContext = peopleManagerDbContext;
        }

        public IActionResult Index()
        {
            var people = _peopleManagerDbContext.People.ToList();

            return View(people);
        }
    }
}
