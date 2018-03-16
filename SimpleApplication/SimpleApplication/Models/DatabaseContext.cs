using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore; 

namespace SimpleApplication.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() { }

        public DatabaseContext(DbContextOptions<DatabaseContext> opts) : base(opts)
        {

        }


        public DbSet<Contact> Contacts { get; set; }

        public DbSet<ContactGroup> ContactGroups { get; set; }

    }
}
