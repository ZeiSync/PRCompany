using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PRCompanies.Models
{
    public class Company
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string ImgHeader { get; set; }
        [Required]
        public string Avatar { get; set; }
        [Required]
        public CompanyType CompanyType { get; set; }
        [Required]
        public string Address { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required, Phone, StringLength(10)]
        public string PhoneNumber    { get; set; }
        [Url]
        public string Website { get; set; }
        [Required]
        public int AccountId { get; set; }

        public IEnumerable<C_PL> C_PLs { get; set; }
        public Overview Overview { get; set; }
        public IEnumerable<Review> Reviews { get; set; }

    }
}
