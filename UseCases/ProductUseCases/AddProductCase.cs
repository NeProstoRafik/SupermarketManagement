using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.Interfaces;
using UseCases.PlaginInterfaces;

namespace UseCases.ProductUseCases
{
    public class AddProductCase : IAddProductCase
    {
        private readonly IProductRepository productRepository;

        public AddProductCase(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public void Execute(Product product)
        {
            productRepository.AddProduct(product);
        }
    }
}
