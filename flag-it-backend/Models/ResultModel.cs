using System.ComponentModel.DataAnnotations;

namespace flag_it_backend.Models
{
    public class ResultModel
    {
        [Key]
        public int Id { get; set; }
        public int Points { get; set; }
        public string UserId { get; set; }
        public string Username { get; set; } = null!;
        public string Difficulty { get; set; } = null!;
        public ApplicationUser User { get; set; }
        public DateTime DateOfResult { get; set; }
        public TimeSpan TimeOfCompletion { get; set; }
    }
}
