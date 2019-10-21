using PRCompany.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRCompany.ViewModel
{
    public class CompanyListViewModel
    {
        public IEnumerable<Company> Companies { get; set; }
        public Company Company { get; set; }
    }
}
