using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GlobaxIT.Models.Context
{
    public class Context:DbContext
    {
        public DbSet<User> users { get; set; }
    }
}