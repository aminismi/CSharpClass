using Model;
using Model.DomainModels;

namespace Service
{
    public class ProductService
    {
        private readonly FinalProjectDbContext _context;

        public ProductService(FinalProjectDbContext context)
        {
            _context = context;
        }

        public bool AddProduct(Product product)
        {
            try
            {
                _context.Product.Add(product);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in AddProduct: {ex.Message}");
                return false;
            }
        }

        public bool DeleteProduct(int id)
        {
            try
            {
                var product = _context.Product.Find(id);
                if (product != null)
                {
                    _context.Product.Remove(product);
                    _context.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in DeleteProduct: {ex.Message}");
                return false;
            }
        }

        public Product GetProductById(int id)
        {
            return _context.Product.FirstOrDefault(p => p.Id == id);
        }

        public bool UpdateProduct(Product product)
        {
            try
            {
                var existingProduct = _context.Product.Find(product.Id);
                if (existingProduct != null)
                {
                    existingProduct.Title = product.Title;
                    existingProduct.UnitPrice = product.UnitPrice;
                    existingProduct.Quantity = product.Quantity;

                    _context.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in UpdateProduct: {ex.Message}");
                return false;
            }
        }
        public List<Product> GetAllProducts()
        {
            return _context.Product.ToList();
        }

    }
}
