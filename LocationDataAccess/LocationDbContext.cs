using LocationEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationDataAccess
{
    public class LocationDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder
                //.UseSqlServer(@"Data Source=LAPTOP-19CH30DO\SQLEXPRESS;Initial Catalog=LocationDb;Integrated Security=SSPI;"); 
                //.UseCosmos(YOUR_COSMOSDB_CREDENTIALS);
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Location>().ToContainer("Location");
            

            modelBuilder.Entity<Location>(entity =>
            {                
                entity.Property(e => e.id).ValueGeneratedOnAdd();
            });

        }

        public DbSet<Location> Locations { get; set; }


    }
}
