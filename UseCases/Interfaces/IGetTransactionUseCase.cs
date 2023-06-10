using CoreBusiness;

namespace UseCases.Interfaces
{
    public interface IGetTransactionUseCase
    {
        IEnumerable<Transaction> Execute(string cashierName, DateTime startDate, DateTime endDate);
    }
}