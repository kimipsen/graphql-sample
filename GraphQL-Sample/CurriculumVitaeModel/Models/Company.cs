using System;
using System.Collections.Generic;

namespace CurriculumVitaeModel.Models
{
    public class Company
    {
        public Company()
        {
            Projects = new List<Project>();
        }
        public int Id { get; set; }
        /// <summary>
        /// Name of the company.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Position within the company.
        /// </summary>
        public string Position { get; set; }
        /// <summary>
        /// Starting date of employment.
        /// </summary>
        public DateTime StartDate { get; set; }
        /// <summary>
        /// End date of employment.
        /// </summary>
        public DateTime? EndDate { get; set; }
        public IList<Project> Projects { get; set; }
    }
}
