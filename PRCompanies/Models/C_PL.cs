using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PRCompanies.Models
{
    public class C_PL
    {
        public int Id { get; set; }
        [Required]
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        [Required]
        public int ProgrammingLanguageId { get; set; }
        public ProgrammingLanguage ProgrammingLanguage { get; set; }
    }
}
