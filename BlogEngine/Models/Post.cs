namespace BlogEngine.Models
{
    public class Post
    {
        public long Id { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public DateTime DatePublished { get; set; }
        public long Author { get; set; }
    }
}
