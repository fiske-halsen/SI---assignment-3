using System.ComponentModel.DataAnnotations;

namespace GrpcService.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public string ReleaseDate { get; set; }
        public bool IsAvailable { get; set; }
        public int StudyProgrammeId { get; set; }

        public ICollection<BookStudentOrder> BookStudentOrders { get; set; }
    }
}
