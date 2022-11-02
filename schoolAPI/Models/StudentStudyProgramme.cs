using System.ComponentModel.DataAnnotations.Schema;

namespace schoolAPI.Models
{
    public class StudentStudyProgramme
    {
        [ForeignKey("StudentId")]
        public int StudentId { get; set; }
        public Student Student { get; set; }
        [ForeignKey("StudyProgrammeId")]
        public int StudyProgrammeId { get; set; }
        public StudyProgramme StudyProgramme { get; set; }

    }
}
