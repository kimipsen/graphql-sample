﻿using CurriculumVitaeModel.Data;
using CurriculumVitaeModel.Models;
using GraphQL.Types;

namespace CurriculumVitaeAPI.Models
{
    public class CompanyType : ObjectGraphType<Company>
    {
        public CompanyType(IProjectRepository projectRepository)
        {
            Field(x => x.Id);
            Field(x => x.Name);
            Field(x => x.Position);
            Field<StringGraphType>("startDate", 
                resolve: context => 
                    context
                    .Source
                    .StartDate
                    .ToString(Constants.DateTimeFormatForPeriods));
            Field<StringGraphType>("endDate", 
                resolve: context => 
                    context
                    .Source
                    .EndDate?
                    .ToString(Constants.DateTimeFormatForPeriods));
            Field<ListGraphType<ProjectType>>("projects",
                arguments: 
                    new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }),
                resolve: context => 
                    projectRepository
                    .ProjectsInCompany(context.Source.Id));
        }
    }
}
