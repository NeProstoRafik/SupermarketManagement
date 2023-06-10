using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.Interfaces;
using UseCases.PlaginInterfaces;

namespace UseCases.ProductUseCases
{
    public class SellProductCase : ISellProductCase
    {
        private readonly IProductRepository productRepository;
        private readonly IRecordTransactionUseCase recordTransactionUseCase;

        public SellProductCase(IProductRepository productRepository, IRecordTransactionUseCase recordTransactionUseCase)
        {
            this.productRepository = productRepository;
            this.recordTransactionUseCase = recordTransactionUseCase;
        }
        public void Execute(string cashierName, int id, int qtyToSell)
        {
            var product = productRepository.GetProductById(id);
            if (product == null)
            {
                return;
            }
            recordTransactionUseCase.Execute(id, qtyToSell, cashierName);
            product.Quantity -= qtyToSell;
            productRepository.UpdateProduct(product);
         
        }
    }
}
