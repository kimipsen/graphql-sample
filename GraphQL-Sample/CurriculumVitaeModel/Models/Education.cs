using System;

namespace CurriculumVitaeModel.Models
{
    public class Education
    {
        public int Id { get; set; }
        public string School { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
