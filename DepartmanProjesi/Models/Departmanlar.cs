using System.ComponentModel.DataAnnotations;

namespace DepartmanProjesi.Models
{
    public class Departmanlar
    {
        [Key]
        public int DepID { get; set; }
        public string DepAd { get; set; }
        
    }
}
