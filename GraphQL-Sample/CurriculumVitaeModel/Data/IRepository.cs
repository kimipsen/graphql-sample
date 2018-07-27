using System.Collections.Generic;
using System.Threading.Tasks;

namespace CurriculumVitaeModel.Data
{
    public interface IRepository<TModel>
    {
        Task<TModel> Get(int id);
        Task<IEnumerable<TModel>> All();
    }
}
