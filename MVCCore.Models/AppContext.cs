using Microsoft.EntityFrameworkCore;
using MVCCore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVCCore.Models
{
   public class AppContext : DbContext
    {
        public AppContext(DbContextOptions<AppContext> options) : base(options)
        {

        } 
        public DbSet<Login> Login { get; set; }
       public DbSet<RegisterModel> Register { get; set; }
    }
}
