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
    public class GetTransactionUseCase : IGetTransactionUseCase
    {
        private readonly ITransactionRepository transactionRepository;

        public GetTransactionUseCase(ITransactionRepository transactionRepository)
        {
            this.transactionRepository = transactionRepository;
        }
        public IEnumerable<Transaction> Execute(string cashierName, DateTime startDate, DateTime endDate)
        {
            return transactionRepository.Search(cashierName, startDate, endDate);
        }
    }
}
