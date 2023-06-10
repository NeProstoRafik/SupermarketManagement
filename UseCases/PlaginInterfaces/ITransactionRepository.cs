

using CoreBusiness;

namespace UseCases.PlaginInterfaces
{
    public interface ITransactionRepository
    {
        public IEnumerable<Transaction> Get(String cashierName);
        public IEnumerable<Transaction> GetByDay(DateTime dateTime, String cashierName);
        public IEnumerable<Transaction> Search( string cashierName, DateTime startDate, DateTime endDate);
        public void Save(int id, double price,string productName, int beforeqty, int soldeqty, string CashierName);
    }
}
