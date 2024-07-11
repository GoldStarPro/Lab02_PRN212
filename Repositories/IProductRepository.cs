using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repositories
{
    public interface IProductRepository
    {
        void SaveProduct(Product p);
        void DeleteProduct(Product p);
        void UpdateProduct(Product p);
        List<Product> GetProducts();
        Product? GetProductById(int id);
    }
}
