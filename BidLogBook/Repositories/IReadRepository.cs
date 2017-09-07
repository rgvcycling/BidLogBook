using BidLogBook.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BidLogBook.Repositories
{
    public interface IReadRepository
    {
        //list of methods to perform on the data
        IEnumerable<LogBook> GetLogsList();
        IEnumerable<LogBook> GetLog(int logId);
    }

    
}
