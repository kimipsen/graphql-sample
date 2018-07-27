namespace CurriculumVitaeModel.Models
{
    public class ProjectSkill
    {
        public Skill Skill { get; set; }
        public int SkillId { get; set; }
        public Project Project { get; set; }
        public int ProjectId { get; set; }
    }
}
