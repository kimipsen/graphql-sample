using CurriculumVitaeModel.Data;
using CurriculumVitaeModel.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CurriculumVitaeData.Repositories
{
    public class CVRepository : ICVRepository
    {
        public Task<IEnumerable<CV>> All()
        {
            throw new NotImplementedException();
        }

        public Task<CV> Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
