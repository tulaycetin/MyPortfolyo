using Microsoft.EntityFrameworkCore;//DbContext için gerekli olan kütüphane 
using MyPortfolyo.DAL.Entities;

namespace MyPortfolyo.DAL.Context
{
    public class MyPortfolioContext : DbContext
    {
        //veri tabanı baglantısı için gerekli server adı  ve db adını ekliyoruz 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-I1A76FN\\TULAY;Initial Catalog=MyPortfolioDB;Integrated Security=True;TrustServerCertificate=True;");
        }

        //veri tabanında oluşacak tabloları dbset içersine yazıp tablo adlarınıda ekliyoruz..
        public DbSet<About> Abouts { get; set; }
        public DbSet<Experince> Experinces { get; set; }
        public DbSet<Contact> GetContacts { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Yorumlar> Yorumlars { get; set; }
        public DbSet<ToDoList> ToDoLists { get; set; }


        //Ardından VEri tabanını Kayıt işlemleri için Migration adımlarına geçiliyor 

    }
}
