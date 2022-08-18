using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapi_dotnet.Models;

namespace webapi_dotnet.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PeopleController : Controller
    {
        List<Person> people = new List<Person>();

        public PeopleController()
        {
            people.Add(new Person { FirstName = "Tim", LastName = "Corey", Id = 1 });
            people.Add(new Person { FirstName = "Tim2", LastName = "Corey2", Id = 2 });
            people.Add(new Person { FirstName = "Tim3", LastName = "Corey3", Id = 3 });
        }

        [HttpGet]
        public List<Person> Get()
        {
            return people;
        }

        [HttpGet("{id}")]
        public Person Get(int id)
        {
            return people.Where(x => x.Id == id).FirstOrDefault();
        }

        //[Route("/People/GetFirstNames")]
        [HttpGet("/People/GetFirstNames")]
        public List<string> GetFirstNames()
        {
            List<string> names = new List<string>();
            foreach (Person person in people)
            {
                names.Add(person.FirstName);
            }
            return names;
        }

        [HttpPost]
        public void Post(Person person)
        {
            people.Add(person);
        }

        [HttpDelete]
        public void Delete(Person person)
        {
            people.Add(person);
        }
        // GET: PeopleController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PeopleController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PeopleController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PeopleController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PeopleController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PeopleController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PeopleController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PeopleController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
