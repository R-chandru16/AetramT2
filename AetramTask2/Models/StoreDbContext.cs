using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AetramTask2.Models
{
    public class StoreDbContext : DbContext
    {

        public StoreDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Product> Aetramdata { get; set; }

    }

}
