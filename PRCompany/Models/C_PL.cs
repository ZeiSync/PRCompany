using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRCompany.Models
{
    public class C_PL
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }

        public int ProgrammingLanguageId { get; set; }
        public ProgrammingLanguage ProgrammingLanguage { get; set; }
    }
}
