using BidLogBook.Models.DTOModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BidLogBook.Models.BidLogViewModels
{
    public class LogListViewModel
    {
        public List<List<BidListDTO>> BidLogs { get; set; }
    }
}
