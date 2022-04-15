using Microsoft.EntityFrameworkCore;
using WEBAPI.Model;

namespace WEBAPI.Data
{
    public class RepoSeyfullahDBContext : DbContext
    {
        public RepoSeyfullahDBContext(DbContextOptions<RepoSeyfullahDBContext> options) : base(options)
        {
        }
        public DbSet<Personel> Personeller { get; set; }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Personel>().HasData(
        //                            new Personel { AdıveİkinciAdı = "Seyfullah", Soyadı = "Tuğcu" },
        //                            new Personel { AdıveİkinciAdı = "Ali", Soyadı = "Koç" }
        //                                         );

        //}

    }
}

