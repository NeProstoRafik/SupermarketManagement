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
    public class ViewProductCase : IViewProductCase
    {
        private readonly IProductRepository iProductrepository;

        public ViewProductCase(IProductRepository iProductrepository)
        {
            this.iProductrepository = iProductrepository;
        }
        public IEnumerable<Product> Execute()
        {
            return iProductrepository.GetProducts();
        }
    }
}
