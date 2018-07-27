using CurriculumVitaeModel.Models;
using GraphQL.Types;

namespace CurriculumVitaeAPI.Models
{
    /// <summary>
    /// Map Link to a graphql object
    /// </summary>
    public class LinkType : ObjectGraphType<Link>
    {
        public LinkType()
        {
            Field(x => x.Id);
            Field(x => x.Url);
            Field(x => x.Description);
        }
    }
}
