using CurriculumVitaeModel.Data;
using CurriculumVitaeModel.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurriculumVitaeData.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly CVContext context;

        public CompanyRepository(CVContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Company>> All()
        {
            return await context.Companies.ToListAsync();
        }

        public async Task<IEnumerable<Company>> CompaniesForCV(int cvId)
        {
            return await context.Companies.Where(x => x.CV.Id == cvId).ToListAsync();
        }

        public async Task<Company> Get(int id)
        {
            return await context.Companies.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
