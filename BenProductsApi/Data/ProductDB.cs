using BenProductsApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BenProductsApi.Data
{
    public class ProductDB : DbContext
    {
        public ProductDB(DbContextOptions<ProductDB> pro) : base(pro)
        {

        }
        public DbSet<Products> Products { get; set; }
    }

    
}
