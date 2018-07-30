using CurriculumVitaeModel.Data;
using GraphQL.Types;

namespace CurriculumVitaeAPI.Models
{
    /// <summary>
    /// GraphQL query object. Entry point.
    /// </summary>
    public class CVQuery : ObjectGraphType
    {
        public CVQuery(ICVRepository cvRepository, 
            ICompanyRepository companyRepository,
            IProjectRepository projectRepository,
            IEducationRepository educationRepository,
            ILinkRepository linkRepository)
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

            Field<CompanyType>("company",
                arguments:
                    new QueryArguments(
                        new QueryArgument<IntGraphType> { Name = "id" }),
                resolve: context =>
                    companyRepository
                    .Get(context.GetArgument<int>("id")));

            Field<ProjectType>("project",
                arguments:
                    new QueryArguments(
                        new QueryArgument<IntGraphType> { Name = "id" }),
                resolve: context =>
                    projectRepository
                    .Get(context.GetArgument<int>("id")));

            Field<EducationType>("education",
                arguments:
                    new QueryArguments(
                        new QueryArgument<IntGraphType> { Name = "id" }),
                resolve: context =>
                    educationRepository
                    .Get(context.GetArgument<int>("id")));

            Field<LinkType>("link",
                arguments:
                    new QueryArguments(
                        new QueryArgument<IntGraphType> { Name = "id" }),
                resolve: context =>
                    linkRepository
                    .Get(context.GetArgument<int>("id")));
        }
    }
}
