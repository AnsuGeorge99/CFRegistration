using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CFRegistration.Models
{
    public class RegisterContext : DbContext
    {
        public RegisterContext() : base("RegisterContext") { }
        public DbSet<Register> RegisterT { get; set; }
    }
}