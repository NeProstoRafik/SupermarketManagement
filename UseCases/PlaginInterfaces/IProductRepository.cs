using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases.PlaginInterfaces
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetProducts();
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        Product GetProductById(int id);
        void DeleteProduct(int productId);
       IEnumerable<Product> GetProductByCategoryId(int id);
    }
}
