using Itrs.Business.Abstract;
using Itrs.DataAccess.Abstract;
using Itrs.DataAccess.Concrete;
using Itrs.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itrs.Business.Concrete
{
    public class LogEntryManager : ILogEntryService
    {
        private ILogEntryDal _logEntryDal;
        public LogEntryManager(ILogEntryDal logEntryDal)
        {
            _logEntryDal = logEntryDal;
        }

        public List<LogEntry> GetAll()
        {
            var currentDate = DateTime.Now;
            var oneWeekAgo = currentDate.AddDays(-7); // Records in the last one week

            var records = _logEntryDal.GetAll()
                .Where(member => member.Timestamp >= oneWeekAgo && member.Timestamp <= currentDate)
                .OrderByDescending(member => member.Timestamp)
                .ToList();

            return records;
        }

        public void Delete(LogEntry logEntry)
        {
            try
            {
                _logEntryDal.Delete(logEntry);
            }
            catch
            {
                throw new Exception("Deletion could not be completed.");
            }
        }


        public List<LogEntry> GetLogsByWord(string word)
        {
            return _logEntryDal.GetAll(p => p.Description.Contains(word.ToLower()));
        }

        public void LogForAdd(Product product)
        {
            using (var context = new ItrsContext())
            {
                LogEntry logEntry = new LogEntry();
                {
                    logEntry.Timestamp = DateTime.Now;
                    logEntry.Description =
                        $"Added a new product named {product.ProductName}" ;
                };

                _logEntryDal.Add(logEntry);
            }
        }

        public void LogForStockUpdate(Product product, string old)
        {
            using (var context = new ItrsContext())
            {
                LogEntry logEntry = new LogEntry();
                {
                    logEntry.Timestamp = DateTime.Now;
                    logEntry.Description = $"The stock number of the Product named {product.ProductName} with id {product.ProductId}," +
                        $" which was {old}, has been updated as {product.StockAmount}.";
                        
                };
                _logEntryDal.Add(logEntry);
            }
        }

        public void LogForUnitPriceUpdate(Product product, string oldPrice)
        {
            using (var context = new ItrsContext())
            {
                LogEntry logEntry = new LogEntry();
                {
                    logEntry.Timestamp = DateTime.Now;
                    logEntry.Description = $"The Product Price of the product named {product.ProductName} with id {product.ProductId} " +
                        $"has been updated from {oldPrice} to {product.UnitPrice}.";
                };
                _logEntryDal.Add(logEntry);
            }
        }
    }
}
