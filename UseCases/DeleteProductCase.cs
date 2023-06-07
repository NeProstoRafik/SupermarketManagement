using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.PlaginInterfaces;

namespace UseCases
{
    public class DeleteProductCase
    {
        private readonly IProductRepository productRepository;

        public DeleteProductCase(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public void Execute(int productId)
        {
            productRepository.DeleteProduct(productId);
        }
    }
}
