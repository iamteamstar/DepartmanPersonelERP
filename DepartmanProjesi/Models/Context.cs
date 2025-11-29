using Microsoft.EntityFrameworkCore;

namespace DepartmanProjesi.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)//bağlantı adresimiz bağlanır optionsBuilder ile yapılır. Standart mvc web.config dosyası olurdu ve bağlantı adresi o web.cofig dosyasının içine yazılırdı. Orada bir connectionstring oluşturup orada yazılırdı aa core mvcde context sınıfına override ile eklenir
        {
            optionsBuilder.UseSqlServer("server=AzadKocakPc;User Id=sa;Password=password1; database=coreDepartman; TrustServerCertificate=True;");//veritabanı ismini burada veriyoruz. inregrated security= true olacak
        }

        public DbSet<Departmanlar> departmanlars { get; set; }//sınıf ismi - veritabanında tutulacak tablonun ismi(departmanlars)
        public DbSet<Personel> personels { get; set; }
    }
}
