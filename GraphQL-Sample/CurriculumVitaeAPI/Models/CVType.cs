﻿using CurriculumVitaeModel.Data;
using CurriculumVitaeModel.Models;
using GraphQL.Types;

namespace CurriculumVitaeAPI.Models
{
    public class CVType : ObjectGraphType<CV>
    {
        public CVType(
            ICompanyRepository companyRepository, 
            IEducationRepository educationRepository)
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
        }
    }
}
