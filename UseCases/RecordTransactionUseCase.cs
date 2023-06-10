using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.Interfaces;
using UseCases.PlaginInterfaces;

namespace UseCases
{
    public class RecordTransactionUseCase : IRecordTransactionUseCase
    {
        private readonly ITransactionRepository transactionRepository;
        private readonly IGetProductByIdCase getProductByIdCase;

        public RecordTransactionUseCase(ITransactionRepository transactionRepository, IGetProductByIdCase getProductByIdCase)
        {
            this.transactionRepository = transactionRepository;
            this.getProductByIdCase = getProductByIdCase;
        }

        public void Execute(int id, int qty, string cashierName)
        {
            var product = getProductByIdCase.Execute(id);
            transactionRepository.Save(id, product.Price.Value, product.Name, product.Quantity.Value, qty, cashierName);
        }

    }
}
