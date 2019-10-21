using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PRCompany.Models
{
    public class ProgrammingLanguage
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Không được để trống trường này")]
        public string Name { get; set; }

        public IEnumerable<C_PL> C_PLs { get; set; }
    }
}
