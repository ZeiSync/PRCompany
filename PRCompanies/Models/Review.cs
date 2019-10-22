using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PRCompanies.Models
{
    public class Review
    {
        public int Id { get; set; }
        [Required]
        public int AccountId { get; set; }
        public Account Account { get; set; }
        [Required]
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        [Required]
        public bool Rate { get; set; }
        [Required]
        public string Comment { get; set; }
        [Required]
        public string Suggest { get; set; }
    }
}
