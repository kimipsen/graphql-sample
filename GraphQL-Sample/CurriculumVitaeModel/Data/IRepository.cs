using System.Collections.Generic;
using System.Threading.Tasks;

namespace CurriculumVitaeModel.Data
{
    /// <summary>
    /// Base repository interface.
    /// </summary>
    /// <typeparam name="TModel"></typeparam>
    public interface IRepository<TModel>
    {
        /// <summary>
        /// Allows for getting a single item by id.
        /// Assumes the id is an int.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<TModel> Get(int id);
        /// <summary>
        /// Allows for getting all items in a collection.
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<TModel>> All();
    }
}
