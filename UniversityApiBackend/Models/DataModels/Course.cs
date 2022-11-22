using System.ComponentModel.DataAnnotations;
using UniversityApiBackend.Enums;

namespace UniversityApiBackend.Models.DataModels
{
    public class Course : BaseEntity
    {
        [Required, StringLength(50)]
        public string Name { get; set; } = string.Empty;
        [Required, StringLength(280)]
        public string ShortDescription { get; set; } = string.Empty;
        [Required]
        public string LongDescription { get; set; } = string.Empty;
        public string TargetAudience { get; set; } = string.Empty;
        public string Objectives { get; set; } = string.Empty;  
        public string Requirements { get; set; } = string.Empty;    
        public Levels Level {  get; set; }
    }
}
