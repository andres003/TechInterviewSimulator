using InterviewSimulator.Domain.Enums;

namespace InterviewSimulator.Domain.Entities
{
    public class InterviewSession
    {

        public Guid Id { get; private set; }
        public string TargetRole { get; private set; } = string.Empty;
        public DifficultyLevel Difficulty { get; private set; }
        public DateTime CreatedAt { get; private set; }

        private readonly List<Question> _questions = new();
        public IReadOnlyCollection<Question> Questions => _questions.AsReadOnly();

        public bool IsCompleted => _questions.Count > 0 && _questions.All(q => q.IsAnswered);

        public double AverageScore => _questions.Any(q => q.IsAnswered)
            ? Math.Round(_questions.Where(q => q.IsAnswered).Average(q => q.Score!.Value), 1)
            : 0.0;
    }
}
