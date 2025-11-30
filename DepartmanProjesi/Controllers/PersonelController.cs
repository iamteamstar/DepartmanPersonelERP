using DepartmanProjesi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace DepartmanProjesi.Controllers
{
    public class PersonelController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var personeller = c.personels.Include(x=>x.depart).ToList();
            return View(personeller);
        }
        [HttpGet]
        public IActionResult PersonelEkle()
        {
            List<SelectListItem> departAdlari = (from x in c.departmanlars.ToList()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.DepAd,
                                                     Value = x.DepID.ToString()
                                                 }).ToList();
            ViewBag.dgr = departAdlari;
            return View();
        }
    }
}
