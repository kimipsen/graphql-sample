using CurriculumVitaeModel.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CurriculumVitaeModel.Data
{
    public interface IProjectRepository : IRepository<Project>
    {
        Task<IEnumerable<Project>> ProjectsInCompany(int companyId);
    }
}
