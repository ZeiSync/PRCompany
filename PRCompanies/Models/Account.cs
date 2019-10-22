using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PRCompanies.Models
{
    public class Account
    {
        public int Id { get; set; }
        [Required]
        public string AccountName { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

        public IEnumerable<Review> Reviews { get; set; }
    }
}
