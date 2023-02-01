
using System.ComponentModel.DataAnnotations;

namespace UniversityApiBackend.Models.DataModels
{
    public class Course: BaseEntity
    {
        [Required, StringLength(50)]
        public string Name { get; set; } = string.Empty;

        [Required, StringLength(180)]
        public string ShortDescription { get; set; } = string.Empty;

        [Required]
        public string Largedescription { get; set; } = string.Empty;

        [Required]
        public string TargetAudience { get; set; } = string.Empty;

        [Required]
        public string Objectives { get; set; } = string.Empty;

        [Required]
        public string Requirements { get; set; } = string.Empty;

        [Required]
        public Levels Level { get; set; } = Levels.Basic;


        public enum Levels
        {
            Basic, Intermediate, Advanced
        } 

    }
}
