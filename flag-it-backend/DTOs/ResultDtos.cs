namespace flag_it_backend.DTOs
{
    public class ResultDtos
    {
        public class ResultDto
        {
            public int Id { get; set; } = int.MinValue;
            public int Points { get; set; } = int.MinValue;
            public string UserId { get; set; } = string.Empty;
            public string Difficulty { get; set; } = string.Empty;
            public DateTime DateOfResult { get; set; } = DateTime.MinValue;
            public TimeSpan TimeOfCompletion { get; set; } = TimeSpan.Zero;

        }

        public class CreateDto
        {
            public int Id { get; set; } = int.MinValue;
            public int Points { get; set; } = int.MinValue;
            public string UserId { get; set; } = string.Empty;
            public string Difficulty { get; set; } = string.Empty;
            public DateTime DateOfResult { get; set; } = DateTime.MinValue;
            public TimeSpan TimeOfCompletion { get; set; } = new TimeSpan(1, 0, 0);
        }

        public class GetByIdDto
        {
            public int Id { get; set; } = int.MinValue;
            public int Points { get; set; } = int.MinValue;
            public string UserId { get; set; } = string.Empty;
            public string Difficulty { get; set; } = string.Empty;
            public DateTime DateOfResult { get; set; } = DateTime.MinValue;
            public TimeSpan TimeOfCompletion { get; set; } = TimeSpan.Zero;
        }

        public class GetByUserIdDto
        {
            public int Id { get; set; } = int.MinValue;
            public int Points { get; set; } = int.MinValue;
            public string UserId { get; set; } = string.Empty;
            public string Difficulty { get; set; } = string.Empty;
            public DateTime DateOfResult { get; set; } = DateTime.MinValue;
            public TimeSpan TimeOfCompletion { get; set; } = TimeSpan.Zero;
        }
    }
}
