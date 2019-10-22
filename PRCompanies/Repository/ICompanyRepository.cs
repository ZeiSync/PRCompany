using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRCompanies.Models.Repository
{
   public interface ICompanyRepository
    {
        IEnumerable<Company> GetAll { get; }
        void Create(Company company);
        int Commit();

    }

    public class CompanyRepository : ICompanyRepository
    {
        private readonly DatabaseContext databaseContext;

        public CompanyRepository(DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }

        public IEnumerable<Company> GetAll => databaseContext.Companies.ToList();

        public int Commit()
        {
            return databaseContext.SaveChanges();
        }

        public void Create(Company company)
        {
            databaseContext.Add(company);
        }
    }
}
