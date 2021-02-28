using System;
using Microsoft.EntityFrameworkCore;
using ReCapProject.Entities;
using ReCapProject.Entities.Concrete;

namespace ReCapProject.DAL.Concrete.EntityFramework
{
    public class ReCapProjectContext:DbContext
    {
     
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=ReCapProject;Trusted_Connection=true");
           optionsBuilder.UseSqlServer(@"Server=.;Database=ReCapProject;User Id=sa;Password=123;");
        }

        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Color> Colors { get; set; }
    }
}
