using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRCompany.Models
{
    public interface ICompanyRepository
    {
        IEnumerable<Company> GetAll { get; }

        void Create(Company company);
        int Commit();
    }
}
