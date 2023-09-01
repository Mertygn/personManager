using Microsoft.AspNetCore.Mvc;
using personManager.webapp.Repostory;

namespace personManager.webapp.Controllers
{
    public class PersonController : Controller
    {
        public readonly PersonRepository _personRepository;
        public PersonController()
        {
            _personRepository = new PersonRepository();
        }
        public IActionResult GetAll()
        {
            var persons = _personRepository.GetAll();
            return View(persons);
        }

        public IActionResult GetById(int id) 
        {
            var person = _personRepository.GetById(id);
            return View(person);
        }

    }
}
