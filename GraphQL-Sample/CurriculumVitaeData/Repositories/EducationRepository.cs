using CurriculumVitaeModel.Data;
using CurriculumVitaeModel.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CurriculumVitaeData.Repositories
{
    public class EducationRepository : IEducationRepository
    {
        public Task<IEnumerable<Education>> All()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Education>> EducationForCV(int cvId)
        {
            throw new NotImplementedException();
        }

        public Task<Education> Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
