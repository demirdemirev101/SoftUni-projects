using System.ComponentModel.DataAnnotations;
using static ForumApp.Data.DataConstants.Post;
namespace ForumApp.Data.Models
{
    public class Post
    {
        [Key]
        public int Id { get; init; }
        [Required]
        [MaxLength(TitleMaxLength)]
        public required string Title { get; set; }
        [Required]
        [MaxLength(ContentMaxLength)]
        public required string Content { get; set; }
    }
}
