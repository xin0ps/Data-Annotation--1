using CodeFirstEntity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstEntity
{
    public class AcademyDb:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string constr = "Data Source=LAPTOP-JLBUNNBV\\SQLEXPRESS;Initial Catalog=AcademyDB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
            
            optionsBuilder.UseSqlServer(constr);
            
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Curators> Curators { get; set; }
        public  DbSet<Departments> Departments { get; set; }

        public DbSet<Faculties> Faculties { get; set; }

        public DbSet<Students> Students { get; set; }
        public DbSet<Teachers> Teachers { get; set; }
        public DbSet<Subjects> Subjects { get; set; }
        public DbSet<Lectures> Lectures { get; set; }
        public DbSet<Groups> Groups { get; set; }


    }
}
