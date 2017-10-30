using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


using ServiceCore.Base;

namespace ServiceCore.Model
{
    class DB : DbContext
    {



        public DbSet<DATA_Student> Students { set; get; }

        public DbSet<DATA_Class> Classes { set; get; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=mydb;Trusted_Connection=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DATA_Student>().HasKey(c => c.Id);

        }
    }
}
