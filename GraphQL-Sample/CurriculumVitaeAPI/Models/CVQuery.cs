using CurriculumVitaeModel.Data;
using GraphQL.Types;

namespace CurriculumVitaeAPI.Models
{
    public class CVQuery : ObjectGraphType
    {
        public CVQuery(ICVRepository cvRepository)
        {
            Field<CVType>("cv",
                arguments: 
                    new QueryArguments(
                        new QueryArgument<IntGraphType> { Name = "id" }),
                resolve: context =>
                    cvRepository
                    .Get(context.GetArgument<int>("id")));

            Field<ListGraphType<CVType>>("cvs",
                resolve: context => cvRepository.All());
        }
    }
}
