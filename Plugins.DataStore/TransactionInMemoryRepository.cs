using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.PlaginInterfaces;

namespace Plugins.DataStore
{
    public class TransactionInMemoryRepository : ITransactionRepository
    {
        private readonly List<Transaction> transactions;

        public TransactionInMemoryRepository()
        {
          transactions = new List<Transaction>();
        }

        public IEnumerable<Transaction> Get(String cashierName)
        {
            if (string.IsNullOrWhiteSpace(cashierName))
            {
                return transactions;
            }
            else
            {
                return transactions.Where(x => string.Equals(x.CashierName, cashierName, StringComparison.OrdinalIgnoreCase));
            }
        }

        public IEnumerable<Transaction> GetByDay(DateTime dateTime, String cashierName)
        {
            if (string.IsNullOrWhiteSpace(cashierName))
            {
                return transactions.Where(x => x.TimeStamp.Date == dateTime.Date);
            }
            else
            {
                return transactions.Where(x => string.Equals(x.CashierName, cashierName, StringComparison.OrdinalIgnoreCase) &&
                x.TimeStamp.Date == dateTime.Date);
            }
          
        }

        public void Save(int id, double price, string productName, int beforeqty, int soldqty, string CashierName)
        {
            int transactionId = 0;
            if (transactions!=null && transactions.Count>0 )
            {
                int maxId = transactions.Max(x => x.TransactionId);
                transactionId= maxId+1;
            }
            else { transactionId = 1; }

            transactions.Add(new Transaction
            {
                ProductId = id,
                TransactionId = transactionId,
                TimeStamp = DateTime.Now,
                ProductName = productName,
                Price = price,
                BeforeQty = beforeqty,
                SoldQty = soldqty,
                CashierName = CashierName                
            }); 
        }

        public IEnumerable<Transaction> Search(string cashierName, DateTime startDate, DateTime endDate)
        {
            if (string.IsNullOrWhiteSpace(cashierName))
            {
                return transactions.Where(x => x.TimeStamp.Date >= startDate && x.TimeStamp <= endDate.AddDays(1).Date);
            }
            else
            {
                return transactions.Where(x => string.Equals(x.CashierName, cashierName, StringComparison.OrdinalIgnoreCase) &&
                x.TimeStamp.Date >= startDate.Date && x.TimeStamp <= endDate.AddDays(1).Date);
            }
        }
    }
}
