using System.ComponentModel.DataAnnotations;

namespace TodoApi.Models
{
    public class TodoItem
    {
        
        public int ID { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Title cannot exceed 100 characters.")]
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsComplete { get; set; }
        
    }
}
