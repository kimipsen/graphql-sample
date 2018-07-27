using CurriculumVitaeModel.Models;
using GraphQL.Types;

namespace CurriculumVitaeAPI.Models
{
    public class ExperienceEnum : EnumerationGraphType<Experience>
    {
        public ExperienceEnum()
        {
            Name = "Experience";
            Description = "Level of experience with a certain skill.";
        }
    }
}
