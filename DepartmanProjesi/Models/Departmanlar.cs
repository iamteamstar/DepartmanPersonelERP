using System.ComponentModel.DataAnnotations;

namespace DepartmanProjesi.Models
{
    public class Departmanlar
    {
        [Key]
        public int DepID { get; set; }
        public string DepAd { get; set; }
       
        public List<Personel> Personels { get; set; }//bire çok bir ilişki oluşturduk. Departmanların içinde birden fazla personel bulunabilir anlamına gelir. Muhsaba departmanında hem veli,hem ahmet hem de zeynep çalışabilir 
    }
}
