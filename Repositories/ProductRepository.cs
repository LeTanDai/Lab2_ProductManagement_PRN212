using BusinessObjects;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Repositories
{
    public class ProductRepository : IProductRepository
    {
        public IEnumerable<Products>GetProducts() => ProductDAO.Instance.GetProducts();
        public int GetMaxProductID() => ProductDAO.Instance.GetMaxProductID();
        public void SaveProduct(Products p) => ProductDAO.Instance.SaveProduct(p);

        public void UpdateProduct(Products p) => ProductDAO.Instance.UpdateProduct(p);

        public void DeleteProduct(Products p) => ProductDAO.Instance.DeleteProduct(p);

        public Products? GetProductById(int id) => ProductDAO.Instance.GetProductById(id);

    }
}
