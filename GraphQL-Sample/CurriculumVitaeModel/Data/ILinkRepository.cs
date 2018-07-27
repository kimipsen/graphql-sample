using CurriculumVitaeModel.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CurriculumVitaeModel.Data
{
    public interface ILinkRepository : IRepository<Link>
    {
        Task<IEnumerable<Link>> LinksForCV(int cvId);
    }
}
