using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogEngineApp.Models
{
    public class Coments
    {
        [Key]
        public int Id { get; set; }
        public string Coment { get; set; }

        [ForeignKey("Id")]
        public int? PostId { get; set; }
        
       
    }
}