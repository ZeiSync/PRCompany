using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace PRCompany.Models
{
    public class PLRepository : IPLRepository
    {
        private readonly Context context;

        public PLRepository(Context _context)
        {
            context = _context;
        }
        public IEnumerable<ProgrammingLanguage> GetAll => context.ProgrammingLanguages.Include(x => x.Id) ;
    }
}
