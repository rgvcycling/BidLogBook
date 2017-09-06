using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BidLogBook.Models.DTOModels
{
    public class LogListDTO
    {
        public int LogId { get; set; }
        public string DateReceived { get; set; }
        public string TimeReceived { get; set; }
        public string Late { get; set; }
        public string IFBNo { get; set; }
        public string VendorName { get; set; }
        public DateTime OpeningDate { get; set; }
        public string Buyer { get; set; }
        public string DeliveryMethod { get; set; }
        public string Notes { get; set; }
        public string ReceivedBy { get; set; }
    }
}
