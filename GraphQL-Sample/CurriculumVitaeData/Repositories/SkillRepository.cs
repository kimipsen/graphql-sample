using CurriculumVitaeModel.Data;
using CurriculumVitaeModel.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CurriculumVitaeData.Repositories
{
    public class SkillRepository : ISkillRepository
    {
        public Task<IEnumerable<Skill>> All()
        {
            throw new NotImplementedException();
        }

        public Task<Skill> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Skill>> SkillsUsedInProject(int projectId)
        {
            throw new NotImplementedException();
        }
    }
}
