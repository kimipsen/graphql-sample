using CurriculumVitaeModel.Data;
using CurriculumVitaeModel.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurriculumVitaeData.Repositories
{
    public class SkillRepository : ISkillRepository
    {
        private readonly CVContext context;

        public SkillRepository(CVContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Skill>> All()
        {
            return await context.Skills.ToListAsync();
        }

        public async Task<Skill> Get(int id)
        {
            return await context.Skills.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Skill>> SkillsByCV(int cvId)
        {
            return await context.Skills.Where(x => x.CV.Id == cvId).ToListAsync();
        }
    }
}
