using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace PRCompany.Models
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly Context context;

        public CompanyRepository(Context context)
        {
            this.context = context;
        }
        public IEnumerable<Company> GetAll => context.Companies.ToList();

        public int Commit()
        {
            return context.SaveChanges();   
        }

        public void Create(Company company)
        {
            context.Add(company);
        }
    }
}
