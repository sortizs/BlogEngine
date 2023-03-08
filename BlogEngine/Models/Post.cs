using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogEngine.Models
{
    public class Post
    {
        [Key]
        public long Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime DatePublished { get; set; }

        [ForeignKey("User")]
        public long AuthorId { get; set; }
        public User Author { get; set; }

        public ICollection<Post> Posts { get; set; }
    }
}
