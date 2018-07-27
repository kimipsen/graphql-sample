using CurriculumVitaeModel.Data;
using CurriculumVitaeModel.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurriculumVitaeData.Repositories
{
    public class LinkRepository : ILinkRepository
    {
        private readonly CVContext context;

        public LinkRepository(CVContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Link>> All()
        {
            return await context.Links.ToListAsync();
        }

        public async Task<Link> Get(int id)
        {
            return await context.Links.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Link>> LinksForCV(int cvId)
        {
            return await context.Links.Where(x => x.CV.Id == cvId).ToListAsync();
        }
    }
}
