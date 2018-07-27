using CurriculumVitaeModel.Data;
using CurriculumVitaeModel.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CurriculumVitaeData.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        public Task<IEnumerable<Company>> All()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Company>> CompaniesForCV(int cvId)
        {
            throw new NotImplementedException();
        }

        public Task<Company> Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
