using CurriculumVitaeModel.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CurriculumVitaeModel.Data
{
    public interface ISkillRepository : IRepository<Skill>
    {
        /// <summary>
        /// Returns all skills for a specific CV.
        /// </summary>
        /// <param name="cvId"></param>
        /// <returns></returns>
        Task<IEnumerable<Skill>> SkillsForCV(int cvId);
    }
}
