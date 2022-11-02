using System.ComponentModel.DataAnnotations.Schema;

namespace GrpcService.Models
{
    public class BookStudentOrder
    {
        [ForeignKey("BookId")]
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int StudentId { get; set; }
    }
}
