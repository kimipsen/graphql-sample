using CurriculumVitaeModel.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CurriculumVitaeModel.Data
{
    public interface ICompanyRepository : IRepository<Company>
    {
        /// <summary>
        /// Returns all companies for a specific CV.
        /// </summary>
        /// <param name="cvId"></param>
        /// <returns></returns>
        Task<IEnumerable<Company>> CompaniesForCV(int cvId);
    }
}
