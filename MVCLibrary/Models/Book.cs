using System.ComponentModel.DataAnnotations;

namespace MVCLibrary.Models
{
    public class Book
    {
        public int BookID { get; set; }
        [MaxLength (255)]
        public string Title { get; set; }
        [MaxLength(50)]
        public string CallNumber { get; set; }
        [MaxLength (50)]
        public string Author { get; set; }
    }
}
