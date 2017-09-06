using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BidLogBook.Entities
{
    public class LogBook
    {
        [Key]
        public int LogId { get; set; }
        [MaxLength(10)]
        public string DateReceived { get; set; }
        [MaxLength(10)]
        public string TimeReceived { get; set; }
        [MaxLength(3)]
        public string Late { get; set; }
        [MaxLength(20), Required]
        public string IFBNo { get; set; }
        [MaxLength(60), Required]
        public string VendorName { get; set; }
        [Required]
        public DateTime OpeningDate { get; set; }
        [Required]
        public string OpeningTime { get; set; }
        [MaxLength(30), Required]
        public string Buyer { get; set; }
        [MaxLength(15), Required]
        public string DeliveryMethod { get; set; }
        [MaxLength(255)]
        public string Notes { get; set; }
        [MaxLength(40)]
        public string ReceivedBy { get; set; }
        [MaxLength(40), Required]
        public string CreatedBy { get; set; }
        [Required]
        public Nullable<DateTime> CreatedOn { get; set; }
        [MaxLength(40)]
        public string ModifiedBy { get; set; }
        public Nullable<DateTime> ModifiedOn { get; set; }
    }
}
