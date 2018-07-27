using CurriculumVitaeModel.Data;
using CurriculumVitaeModel.Models;
using GraphQL.Types;

namespace CurriculumVitaeAPI.Models
{
    public class CVType : ObjectGraphType<CV>
    {
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
            Field<ListGraphType<SkillType>>("links",
                arguments:
                    new QueryArguments(
                        new QueryArgument<IntGraphType> { Name = "id" }),
                resolve: context =>
                    linkRepository
                    .LinksForCV(context.Source.Id));
        }
    }
}
