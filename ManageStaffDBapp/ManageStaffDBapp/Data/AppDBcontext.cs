using ManageStaffDBapp.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageStaffDBapp.Data
{
    internal class AppDBcontext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ManageStaffAppDB;Trusted_Connection=True");
        }

        public DbSet<User> UsersRP { get; set; }
        public DbSet<Position> PositionsRP { get; set; }
        public DbSet<Department> DepartmentsRP { get; set; }

        public AppDBcontext()
        {
            Database.EnsureCreated();
        }
    }
}
