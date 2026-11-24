namespace InterviewSimulator.Domain.Entities
{
    public class Question
    {
        public Guid Id { get; private set; }
        public Guid InterviewSessionId { get; private set; }
        public int OrderIndex { get; private set; }
        public string Content { get; private set; } = string.Empty;

        // Evaluation fields (populated once the user answers)
        public string? UserAnswer { get; private set; }
        public int? Score { get; private set; }
        public string? Feedback { get; private set; }
        public string? IdealAnswer { get; private set; }
        public bool IsAnswered => Score.HasValue;


        // Required by EF Core
        private Question() { }

        public Question(Guid interviewSessionId, int orderIndex, string content)
        {
            if (string.IsNullOrWhiteSpace(content))
                throw new ArgumentException("Question content cannot be empty.", nameof(content));

            Id = Guid.NewGuid();
            InterviewSessionId = interviewSessionId;
            OrderIndex = orderIndex;
            Content = content;
        }

        public void SubmitEvaluation(string userAnswer, int score, string feedback, string idealAnswer)
        {
            if (score < 1 || score > 10)
                throw new ArgumentOutOfRangeException(nameof(score), "Score must be between 1 and 10.");

            UserAnswer = userAnswer;
            Score = score;
            Feedback = feedback;
            IdealAnswer = idealAnswer;
        }
    }
}
