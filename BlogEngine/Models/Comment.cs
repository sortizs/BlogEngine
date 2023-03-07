namespace BlogEngine.Models
{
    public class Comment
    {
        public long Id { get; set; }
        public string? Content { get; set; }
        public long Post { get; set; }
    }
}
