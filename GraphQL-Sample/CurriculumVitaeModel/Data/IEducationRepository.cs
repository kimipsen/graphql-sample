using CurriculumVitaeModel.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CurriculumVitaeModel.Data
{
    public interface IEducationRepository : IRepository<Education>
    {
        Task<IEnumerable<Education>> EducationForCV(int cvId);
    }
}
