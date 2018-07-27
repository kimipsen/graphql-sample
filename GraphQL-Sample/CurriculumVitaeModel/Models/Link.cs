namespace CurriculumVitaeModel.Models
{
    public class Link
    {
        public int Id { get; set; }
        public CV CV { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
    }
}
