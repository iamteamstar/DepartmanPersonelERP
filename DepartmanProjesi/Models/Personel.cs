using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace DepartmanProjesi.Models
{
    public class Personel
    {
        [Key]
        public int PersonelID { get; set; }
        public string PersonelAd { get; set; }
        public string PersonelSoyad { get; set; }
        public string PersonelSehir { get; set; }
        public int DepartID { get; set; }
        public Departmanlar depart { get;set; }//ilişkili olduğu sınıftan nesne türetilir
    }
}
