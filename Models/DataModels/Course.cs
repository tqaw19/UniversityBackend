using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace University.Models.DataModels
{
    public class Course:BaseEntity
    {
        [Required, StringLength(50)]
        public string Name { get; set; }= string.Empty;
        [Required, StringLength(280)]
        public string ShortDescription { get; set; }= string.Empty;
        
        public string LargeDescription { get; set; }= string.Empty;
        [Required]
        public string TargetAudience { get; set; } = string.Empty;
        [Required]
        public string Objectives { get; set; }=string.Empty;
        [Required]
        public DifficultyLevel Difficulty{ get; set; }
        public enum DifficultyLevel 
        {
            [Display(Name ="Básico")]
            Basico, 
            [Display(Name="Intermedio")]
            Intermedio, 
            [Display(Name = "Avanzado")]
            Avanzado}



    }
}
