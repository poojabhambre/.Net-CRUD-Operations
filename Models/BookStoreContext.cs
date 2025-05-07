using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Book.Models
{
    public class BookStoreContext : DbContext 
    {
        public DbSet<BookStore> Bookobj {  get; set; }
    }
}