using CurriculumVitaeModel.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CurriculumVitaeModel.Data
{
    public interface ILinkRepository : IRepository<Link>
    {
        /// <summary>
        /// Returns all links for a specific CV.
        /// </summary>
        /// <param name="cvId"></param>
        /// <returns></returns>
        Task<IEnumerable<Link>> LinksForCV(int cvId);
    }
}
