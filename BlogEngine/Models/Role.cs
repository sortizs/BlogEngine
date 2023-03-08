using System.ComponentModel.DataAnnotations;

namespace BlogEngine.Models
{
    public class Role
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public User User { get; set; }

    }
}
