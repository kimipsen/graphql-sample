using System.Collections.Generic;

namespace CurriculumVitaeModel.Models
{
    public class Skill
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Experience Experience { get; set; }
        public CV CV { get; set; }
    }
}
