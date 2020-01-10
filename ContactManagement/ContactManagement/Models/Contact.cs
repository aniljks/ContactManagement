using System;
using System.Collections.Generic;

namespace ContactManagement.Models
{
    public partial class Contact
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public decimal? Phone { get; set; }
        public bool? Status { get; set; }
    }
}
