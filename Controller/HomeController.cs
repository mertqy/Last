using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Last.Models;

namespace PersonList.Controllers
{
    public class HomeController : Controller
    {
        private static List<Person> PersonList = new();

        public IActionResult Index()
        {
            var model = new List<Last.Models.Person>();
            return View(PersonList);
        }

        [HttpPost]
        public IActionResult AddPerson([FromBody] Person newPerson)
        {
            if (ModelState.IsValid)
            {
                PersonList.Add(newPerson);
                return Ok(PersonList);
            }
            return RedirectToAction("Index");
        }

        public IActionResult RemovePerson(int index)
        {
            PersonList.RemoveAt(index);
            return RedirectToAction("Index");
        }
    }
}