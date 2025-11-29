using Microsoft.AspNetCore.Mvc;
using DepartmanProjesi.Models;
namespace DepartmanProjesi.Controllers
{
    public class departController : Controller
    {
        Context c=new Context();
        public IActionResult Index()
        {
            var degerler = c.departmanlars.ToList();

            return View(degerler);
        }
        [HttpGet]//sayfa yüklendiğinde çalışır
        public IActionResult YeniDepEkle()
        {
            return View();
        }
        [HttpPost]//sayfada post işlemi yapılınca çalışacak,parametre alır
        public IActionResult YeniDepEkle(Departmanlar d)
        {
            c.departmanlars.Add(d);//contextren nesne türetmemiz gerekir
            c.SaveChanges();//degisiklikleri kaydet
            return RedirectToAction("Index");//beni bir actiona yönlendir: Index
           
           

        }
    }
}
