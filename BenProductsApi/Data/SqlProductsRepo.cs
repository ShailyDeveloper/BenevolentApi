using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BenProductsApi.Models;

namespace BenProductsApi.Data
{
    public class SqlProductsRepo : IProducts
    {
        private readonly ProductDB _context;

        public SqlProductsRepo(ProductDB context)
        {
            _context = context;

        }
        public void CreateProduct(Products bt)
        {
            if (bt == null)
            {
                throw new ArgumentNullException(nameof(bt));
            }
            _context.Products.Add(bt);
        }

        public void DeleteProduct(Products bt)
        {
            if (bt == null)
            {
                throw new ArgumentNullException(nameof(bt));
            }

            _context.Products.Remove(bt);
        }

        public Products GetProductbyID(int ID)
        {
            return _context.Products.FirstOrDefault(p => p.ID == ID);
        }

        public IEnumerable<Products> GetProducts()
        {
            return _context.Products.ToList();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateProduct(Products bt)
        {
            //Nothing
        }
    }
}
