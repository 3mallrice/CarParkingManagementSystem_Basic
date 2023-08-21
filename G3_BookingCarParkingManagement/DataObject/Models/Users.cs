using System;
using System.Collections.Generic;

namespace DataObject.Models
{
    public partial class User
    {
        public User()
        {
            Books = new HashSet<Book>();
            Cars = new HashSet<Car>();
        }

        public int UserId { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Phone { get; set; }
        public int? Role { get; set; }
        public int? Status { get; set; }

        public virtual ICollection<Book> Books { get; set; }
        public virtual ICollection<Car> Cars { get; set; }
    }
}
