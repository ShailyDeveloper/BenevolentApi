using BenProductsApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BenProductsApi.Data
{
    public interface IProducts
    {
        bool SaveChanges();
        IEnumerable<Products> GetProducts();
        Products GetProductbyID(int ID);
        void CreateProduct(Products bt);
        void UpdateProduct(Products bt);
        void DeleteProduct(Products bt);
    }
}
