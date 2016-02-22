using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Bootstrap.Models
{
    public class BootstrapContext : DbContext
    {
        public BootstrapContext() : base("DefaultConnection")
        {
        }
        public DbSet<Snippet> Snippets { get; set; } 

    }
}