using CurriculumVitaeModel.Data;
using CurriculumVitaeModel.Models;
using GraphQL.Types;

namespace CurriculumVitaeAPI.Models
{
    /// <summary>
    /// Map Project to a graphql object
    /// </summary>
    public class ProjectType : ObjectGraphType<Project>
    {
        public ProjectType()
        {
            Field(x => x.Id);
            Field(x => x.Name);
            Field(x => x.Description);
        }
    }
}
