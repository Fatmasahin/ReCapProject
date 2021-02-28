using System;
using Microsoft.EntityFrameworkCore;
using ReCapProject.Entities;

namespace ReCapProject.DAL.Concrete.EntityFramework
{
    public class ReCapProjectContext:DbContext
    {
     
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=ReCapProject;Trusted_Connection=true");
           optionsBuilder.UseSqlServer(@"Server=.;Database=ReCapProject;User Id=sa;Password=123;");
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }
    }
}
