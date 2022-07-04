using System.ComponentModel.DataAnnotations;

namespace BlazorCQRS.Models
{
    public class PostModel
    {
        [Required]
        [StringLength(10, ErrorMessage = "Title is too long.")]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public int BlogId { get; set; }
    }
}
