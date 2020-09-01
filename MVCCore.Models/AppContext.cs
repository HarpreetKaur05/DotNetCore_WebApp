using Microsoft.EntityFrameworkCore;
using MVCCore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVCCore
{
   public class AppContext : DbContext
    {
        public AppContext(DbContextOptions<AppContext> options) : base(options)
        {

        }
        public DbSet<Doctor> Doctor { get; set; }
        public DbSet<Login> Login { get; set; }
        
    }
}
