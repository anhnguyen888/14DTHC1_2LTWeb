using System.ComponentModel.DataAnnotations;

namespace _14DTHC1_2.Models
{
    public class Book
    {
        public int BookId { get; set; }

        [Required(ErrorMessage = "Tiêu đề không được trống!")]
        [StringLength(200, ErrorMessage = "Độ dài không vượt quá 200 ký tự")]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        public int Year { get; set; }

        public string Cover { get; set; }
    }
}