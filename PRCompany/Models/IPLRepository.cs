using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRCompany.Models
{
    public interface IPLRepository
    {
        IEnumerable<ProgrammingLanguage> GetAll { get; }
    }
}
