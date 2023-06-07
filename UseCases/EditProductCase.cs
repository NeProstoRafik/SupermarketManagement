using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.Interfaces;
using UseCases.PlaginInterfaces;

namespace UseCases
{
    public class EditProductCase : IEditProductCase
    {
        private readonly IProductRepository productRepository;

        public EditProductCase(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public void Execute(Product product)
        {
            productRepository.UpdateProduct(product);
        }
    }
}
