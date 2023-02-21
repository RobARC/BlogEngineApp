using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BlogEngineApp.Models
{
    public class Posts
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }

        public string Author { get; set; }

        public DateTime CreatedAt { get; set; }
    
        public string Status { get; set; }


    }
}
