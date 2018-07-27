using CurriculumVitaeModel.Data;
using CurriculumVitaeModel.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurriculumVitaeData.Repositories
{
    public class EducationRepository : IEducationRepository
    {
        private readonly CVContext context;

        public EducationRepository(CVContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Education>> All()
        {
            return await context.Educations.ToListAsync();
        }

        public async Task<IEnumerable<Education>> EducationForCV(int cvId)
        {
            return await context.Educations.Where(x => x.CV.Id == cvId).ToListAsync();
        }

        public async Task<Education> Get(int id)
        {
            return await context.Educations.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
