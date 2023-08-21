using System;
using System.Collections.Generic;

namespace DataObject.Models
{
    public partial class Book
    {
        public int BookId { get; set; }
        public int? SlotxeId { get; set; }
        public int? CarId { get; set; }
        public DateTime? BookingTime { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? Status { get; set; }
        public int? UserId { get; set; }

        public virtual Car? Car { get; set; }
        public virtual Slotxe? Slotxe { get; set; }
        public virtual User? User { get; set; }
    }
}
