using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class BookStoreEntities : DbContext
    {
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Inventory> Inventories { get; set; }
        public virtual DbSet<Price> Prices { get; set; }
        public virtual DbSet<sell> sells { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}