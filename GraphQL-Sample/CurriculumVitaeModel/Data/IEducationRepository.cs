using CurriculumVitaeModel.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CurriculumVitaeModel.Data
{
    public interface IEducationRepository : IRepository<Education>
    {
        /// <summary>
        /// Returns all educations for a specific CV.
        /// </summary>
        /// <param name="cvId"></param>
        /// <returns></returns>
        Task<IEnumerable<Education>> EducationForCV(int cvId);
    }
}
