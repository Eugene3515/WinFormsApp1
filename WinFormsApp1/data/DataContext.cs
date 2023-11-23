using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.data
{
    internal class DataContext:DbContext
    {
        public DbSet<Workers> worker {  get; set; }
        public DbSet<WorkList> workLists { get; set; }
        public DbSet<login> logins { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=agencywork;Trusted_Connection=True;");
        }
    }
}
