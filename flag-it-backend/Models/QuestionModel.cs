using System.ComponentModel.DataAnnotations;

namespace flag_it_backend.Models
{
    public class QuestionModel
    {
        [Key]
        public int Id { get; set; }
        public string Difficulty { get; set; } = null!;
        public int CountryId { get; set; }
        public CountryModel Country { get; set; }
    }
}
