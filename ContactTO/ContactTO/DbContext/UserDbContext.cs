using ContactTO.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ContactTO
{
    public class UserDbContext:DbContext
    {
        public UserDbContext():base("ConnectionTo")
            {
            }
        public DbSet<User> Users { set; get; }
    }
}