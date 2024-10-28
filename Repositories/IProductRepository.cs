using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Products> GetProducts();
        int GetMaxProductID();

        void SaveProduct(Products p);

        void UpdateProduct(Products p);

        void DeleteProduct(Products p);

        Products? GetProductById(int id);

    }
}
