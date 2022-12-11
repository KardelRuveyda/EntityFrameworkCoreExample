using EntityFrameworkCoreExample.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCoreExample.DataContext
{
    public class AppDbContext:DbContext
    {
        public DbSet<Student> Students { get; set; }    
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=YourServerName;Initial Catalog=YourDatabaseName;Integrated Security=True");
        }
    }
}
