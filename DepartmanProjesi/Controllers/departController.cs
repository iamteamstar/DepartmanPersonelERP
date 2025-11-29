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

        public IActionResult DepartmanSil(int id)
        {
            var depSil = c.departmanlars.Find(id);//gönderdiğim id yi bul
            c.departmanlars.Remove(depSil);//depsilden gelen değerin olduğu satırın tamamını(yani aranan değeri)sil
            c.SaveChanges();
            return RedirectToAction("Index");
            
        }
        public IActionResult DepartmanGetir(int id)//öncelikle güncellemek istediğimiz değerleri sayfamıza taşımamız  gerek
        {
            var depGetir = c.departmanlars.Find(id);
            return View("DepartmanGetir",depGetir);//veya direkt depGetir
        }
        public IActionResult DepartmanGuncelle(Departmanlar d)
        {
            var depGuncelle = c.departmanlars.Find(d.DepID);
            depGuncelle.DepAd= d.DepAd;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
