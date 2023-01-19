using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;

namespace Sign_Up_Form
{
    class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }  
        public ApplicationContext() : base("DefaultConnection") { }
    }
}
