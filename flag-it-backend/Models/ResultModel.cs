using System.ComponentModel.DataAnnotations;

namespace flag_it_backend.Models
{
    public class ResultModel
    {
        [Key]
        public int Id { get; set; }
        public int Points { get; set; }
        public int UserId { get; set; }
        public string Difficulty { get; set; } = null!;
        public ApplicationUser User { get; set; }
        public DateTime DateOfResult { get; set; }
        public TimeSpan TimeOfCompletion { get; set; }

    }
}
