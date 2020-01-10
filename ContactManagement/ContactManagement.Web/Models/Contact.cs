using ContactManagement.Web.Data;
using System;
using System.Collections.Generic;

namespace ContactManagement.Web.Models
{
    public partial class Contact : BaseEntity
    {
        //public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public decimal? Phone { get; set; }
        public bool? Status { get; set; }
    }
}
