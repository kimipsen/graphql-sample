﻿using CurriculumVitaeModel.Data;
using CurriculumVitaeModel.Models;
using GraphQL.Types;

namespace CurriculumVitaeAPI.Models
{
    public class ProjectType : ObjectGraphType<Project>
    {
        public ProjectType(ISkillRepository skillRepository)
        {
            Field(x => x.Id);
            Field(x => x.Name);
            Field(x => x.Description);
            Field<ListGraphType<SkillType>>("skillsUsed",
                arguments: 
                    new QueryArguments(
                        new QueryArgument<IntGraphType> { Name = "id" }),
                resolve: context => 
                    skillRepository
                    .SkillsUsedInProject(context.Source.Id));
        }
    }
}