using DepartmanProjesi.Models;
using Microsoft.AspNetCore.Mvc;

namespace DepartmanProjesi.Controllers
{
    public class PersonelController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var personeller = c.personels.ToList();
            return View(personeller);
        }
    }
}
