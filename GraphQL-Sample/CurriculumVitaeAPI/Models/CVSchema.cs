using GraphQL;
using GraphQL.Types;

namespace CurriculumVitaeAPI.Models
{
    public class CVSchema : Schema
    {
        public CVSchema(IDependencyResolver resolver)
            : base(resolver)
        {
            Query = resolver.Resolve<CVQuery>();
        }
    }
}
