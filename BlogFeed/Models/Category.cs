using System.ComponentModel.DataAnnotations;

namespace BlogFeed.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Category Name is Required!!")]
        [MaxLength(150, ErrorMessage ="Category Name cannot exceed 150 characters!!")]
        public string Name { get; set; }

        public string? Description { get; set; }

        public ICollection<Post>? Posts { get; set; }
    }
}
