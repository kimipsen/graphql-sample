using CurriculumVitaeModel.Models;
using GraphQL.Types;

namespace CurriculumVitaeAPI.Models
{
    public class SkillType : ObjectGraphType<Skill>
    {
        public SkillType()
        {
            Field(x => x.Id);
            Field(x => x.Name);
            Field<ExperienceEnum>("experience");
        }
    }
}
