namespace CurriculumVitaeModel.Models
{
    public enum Experience : byte
    {
        /// <summary>
        /// No experience at all.
        /// </summary>
        None = 0,
        /// <summary>
        /// Got some experience, but only just gotten it working in most cases.
        /// </summary>
        Beginner = 1,
        /// <summary>
        /// Professional level experience, using it in a product.
        /// </summary>
        Experienced = 2,
        /// <summary>
        /// Considered an expert in thi´s field.
        /// </summary>
        Expert = 4
    }
}
