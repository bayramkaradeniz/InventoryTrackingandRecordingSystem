using Itrs.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itrs.Business.Abstract
{
    public interface ILogEntryService
    {

        List<LogEntry> GetAll();
        List<LogEntry> GetLogsByWord(string word);
        void LogForAdd(Product product);
        void LogForStockUpdate(Product product, string old);
        void Delete(LogEntry logEntry);
        void LogForUnitPriceUpdate(Product product, string oldStock);
    }
}
