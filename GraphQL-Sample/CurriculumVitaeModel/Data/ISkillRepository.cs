using CurriculumVitaeModel.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CurriculumVitaeModel.Data
{
    public interface ISkillRepository : IRepository<Skill>
    {
        Task<IEnumerable<Skill>> SkillsUsedInProject(int projectId);
    }
}
