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
    public class ViewProductByCategoryId : IViewProductByCategoryId
    {
        private readonly IProductRepository productRepository;

        public ViewProductByCategoryId(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public IEnumerable<Product> Execute(int id)
        {
            return productRepository.GetProductByCategoryId(id);
        }
    }
}
