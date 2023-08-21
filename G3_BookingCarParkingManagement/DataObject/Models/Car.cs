using System;
using System.Collections.Generic;

namespace DataObject.Models
{
    public partial class Car
    {
        public Car()
        {
            Books = new HashSet<Book>();
        }

        public int CarId { get; set; }
        public int? UserId { get; set; }
        public string? Bsx { get; set; }
        public int? Status { get; set; }

        public virtual User? User { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}
