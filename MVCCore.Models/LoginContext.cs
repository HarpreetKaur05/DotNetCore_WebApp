using Microsoft.EntityFrameworkCore;
using MVCCore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVCCore
{
   public class LoginContext : DbContext
    {
        public LoginContext(DbContextOptions<LoginContext> options) : base(options)
        {

        } 
        public DbSet<Login> Login { get; set; }
        
    }
}
