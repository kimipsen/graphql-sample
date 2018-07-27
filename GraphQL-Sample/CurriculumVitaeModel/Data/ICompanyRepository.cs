using CurriculumVitaeModel.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CurriculumVitaeModel.Data
{
    public interface ICompanyRepository : IRepository<Company>
    {
        Task<IEnumerable<Company>> CompaniesForCV(int cvId);
    }
}
