using CurriculumVitaeModel.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CurriculumVitaeModel.Data
{
    public interface IProjectRepository : IRepository<Project>
    {
        /// <summary>
        /// Returns all projects for a specific company.
        /// </summary>
        /// <param name="companyId"></param>
        /// <returns></returns>
        Task<IEnumerable<Project>> ProjectsInCompany(int companyId);
    }
}
