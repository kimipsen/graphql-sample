using CurriculumVitaeModel.Data;
using CurriculumVitaeModel.Models;
using GraphQL.Types;

namespace CurriculumVitaeAPI.Models
{
    /// <summary>
    /// Map CV to a graphql object
    /// </summary>
    public class CVType : ObjectGraphType<CV>
    {
        /// <summary>
        /// Includes advanced mappings for foreign keys.
        /// </summary>
        /// <param name="companyRepository"></param>
        /// <param name="educationRepository"></param>
        /// <param name="skillRepository"></param>
        /// <param name="linkRepository"></param>
        public CVType(
            ICompanyRepository companyRepository, 
            IEducationRepository educationRepository,
            ISkillRepository skillRepository,
            ILinkRepository linkRepository)
        {
            Field(x => x.Id);
            Field(x => x.Name);
            Field<ListGraphType<CompanyType>>("companies",
                arguments:
                    new QueryArguments(
                        new QueryArgument<IntGraphType> { Name = "id" }),
                resolve: context =>
                    companyRepository
                    .CompaniesForCV(context.Source.Id));

            Field<ListGraphType<EducationType>>("education",
                arguments:
                    new QueryArguments(
                        new QueryArgument<IntGraphType> { Name = "id" }),
                resolve: context =>
                    educationRepository
                    .EducationForCV(context.Source.Id));

            Field<ListGraphType<SkillType>>("skills",
                arguments:
                    new QueryArguments(
                        new QueryArgument<IntGraphType> { Name = "id" }),
                resolve: context =>
                    skillRepository
                    .SkillsForCV(context.Source.Id));

            Field<ListGraphType<LinkType>>("links",
                arguments:
                    new QueryArguments(
                        new QueryArgument<IntGraphType> { Name = "id" }),
                resolve: context =>
                    linkRepository
                    .LinksForCV(context.Source.Id));
        }
    }
}
