using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.PlaginInterfaces;

namespace Plugins.DataStore
{
    public class ProductInMemoryRepository : IProductRepository
    {
        private List<Product> products;
        public ProductInMemoryRepository()
        {
            products = new List<Product>()
            {
                new Product {CategoryId=1, Name="Чай", Price=100, ProductId=1, Quantity=100 },
            };
        }

        public void AddProduct(Product product)
        {
            if (products.Any(x => x.Name.Equals(product.Name, StringComparison.OrdinalIgnoreCase))) return;
            if (products.Count > 0 && products != null)
            {
                var maxId = products.Max(x => x.ProductId);

                product.ProductId = maxId + 1;
            }
            else
            {
                product.ProductId = 1;
            }

            products.Add(product);
        }

        public IEnumerable<Product> GetProducts()
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Product product)
        {
            var productToUpdate = GetProductById(product.ProductId);
            if (productToUpdate != null)
            {
                productToUpdate.Name = product.Name;
                productToUpdate.ProductId = product.ProductId;
                productToUpdate.Price = product.Price;
                productToUpdate.Quantity = product.Quantity;
            }
        }
        public Product GetProductById(int id)
        {
           return products?.FirstOrDefault(x => x.ProductId == id);
        }

        public void DeleteProduct(int productId)
        {
           var productToDelete= GetProductById(productId);
            if (productToDelete != null)
                products.Remove(productToDelete);
        }
    }
}
