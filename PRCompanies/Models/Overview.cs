using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PRCompanies.Models
{
    public class Overview
    {
        public int Id { get; set; }
        [Required]
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        [Required, StringLength(50)]
        public string Header { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
