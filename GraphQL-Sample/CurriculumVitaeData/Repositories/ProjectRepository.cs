using CurriculumVitaeModel.Data;
using CurriculumVitaeModel.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CurriculumVitaeData.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        public Task<IEnumerable<Project>> All()
        {
            throw new NotImplementedException();
        }

        public Task<Project> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Project>> ProjectsInCompany(int companyId)
        {
            throw new NotImplementedException();
        }
    }
}
