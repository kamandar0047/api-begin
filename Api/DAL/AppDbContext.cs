using Api.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Employer> Employer { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employer>()
                .HasData(
                new Employer { Id=1, FullName="Aydin Xirdalanli", Age=38, Address="Xirdalan",BookName="Olmez Xiridarlar",BookPrice=35,BookID=1},
                 new Employer { Id = 2, FullName = "Resad Dagli ", Age = 44, Address = "Yasamal", BookName = "Sergi", BookPrice = 40, BookID = 2 },
                  new Employer { Id = 3, FullName = "Mehman Ehmedli", Age = 35, Address = "Ehmedli", BookName = "Uzaq Diyar", BookPrice = 45, BookID = 3 },
                   new Employer { Id = 4, FullName = "Perviz Bulbule", Age = 38, Address = "Bulbule", BookName = "Turkan", BookPrice = 55, BookID =4 },
                    new Employer { Id = 5, FullName = "Elsen Xezer", Age = 38, Address = "Xezer", BookName = "Goyler", BookPrice = 75, BookID = 5 },
                    new Employer { Id = 6, FullName = "Rufet Nasosnu", Age = 38, Address = "Nasosnu", BookName = "Getdi geder gelmeze", BookPrice = 85, BookID = 6 }

                );
        }
    }
}
