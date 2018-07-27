using System.Collections.Generic;

namespace CurriculumVitaeModel.Models
{
    public class Project
    {
        public Project()
        {
        }

        public int Id { get; set; }
        /// <summary>
        /// Name of project.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// A brief description of the project.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// A list of skills used in the current project.
        /// </summary>
        public Company Company { get; set; }
    }
}
