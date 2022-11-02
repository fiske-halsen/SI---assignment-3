using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace schoolAPI.Models
{
    public class StudyProgramme
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }

        public ICollection<StudentStudyProgramme> StudentStudyProgramme { get; set; }
    }
}
