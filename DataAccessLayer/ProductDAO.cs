using BusinessObjects;

namespace DataAccessLayer
{
    public class ProductDAO
    {
        private static ProductDAO instance = null;
        private static readonly object instanceLock = new object();

        public MyStoreDBContext _context;

        public static ProductDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ProductDAO();
                    }
                    return instance;
                }
            }
        }

        public void SaveProduct(Products p)
        {
            _context = new();
            _context.Products.Add(p);
            _context.SaveChanges();
        }

        public void UpdateProduct(Products p)
        {
            _context = new();
            _context.Products.Update(p);
            _context.SaveChanges();
        }

        public void DeleteProduct(Products p)
        {
            _context = new();
            _context.Products.Remove(p);
            _context.SaveChanges();
        }
        public IEnumerable<Products> GetProducts()
        {
            _context = new();
            return _context.Products.ToList();
        }
        public Products? GetProductById(int productId)
        {
            return _context.Products.FirstOrDefault(p => p.ProductId == productId);
        }


        public int GetMaxProductID()
        {
            try
            {
                using (var db = new MyStoreDBContext())
                {
                    int maxId = db.Products.DefaultIfEmpty().Max(p => p.ProductId);
                    return maxId + 1;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}