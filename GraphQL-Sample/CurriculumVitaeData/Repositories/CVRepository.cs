using CurriculumVitaeModel.Data;
using CurriculumVitaeModel.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CurriculumVitaeData.Repositories
{
    public class CVRepository : ICVRepository
    {
        private readonly CVContext context;

        public CVRepository(CVContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<CV>> All()
        {
            return await context.CVs.ToListAsync();
        }

        public async Task<CV> Get(int id)
        {
            return await context.CVs.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
