using System.ComponentModel.DataAnnotations;

namespace flag_it_backend.Models
{
    public class CountryModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Continent { get; set; }
        public string? Description { get; set; }
        public string? FlagImage { get; set; }
        public QuestionModel? Question { get; set; }
    }
}
