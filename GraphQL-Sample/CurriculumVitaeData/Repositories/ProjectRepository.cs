using CurriculumVitaeModel.Data;
using CurriculumVitaeModel.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurriculumVitaeData.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly CVContext context;

        public ProjectRepository(CVContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Project>> All()
        {
            return await context.Projects.ToListAsync();
        }

        public async Task<Project> Get(int id)
        {
            return await context.Projects.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Project>> ProjectsInCompany(int companyId)
        {
            return await context.Projects.Where(x => x.Company.Id == companyId).ToListAsync();
        }
    }
}
