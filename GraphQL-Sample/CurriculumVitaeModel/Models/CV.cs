﻿using System.Collections.Generic;

namespace CurriculumVitaeModel.Models
{
    public class CV
    {
        public CV()
        {
            Companies = new List<Company>();
            Education = new List<Education>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Company> Companies { get; set; }
        public IList<Education> Education { get; set; }
    }
}
