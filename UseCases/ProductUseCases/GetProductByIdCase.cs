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
    public class GetProductByIdCase : IGetProductByIdCase
    {
        private readonly IProductRepository productRepository;

        public GetProductByIdCase(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public Product Execute(int id)
        {
            return productRepository.GetProductById(id);
        }
    }
}
