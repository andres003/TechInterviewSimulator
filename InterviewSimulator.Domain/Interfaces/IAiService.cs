using InterviewSimulator.Domain.Enums;

namespace InterviewSimulator.Domain.Interfaces
{
    public record EvaluationResult(int Score, string Feedback, string IdealAnswer);

    public interface IAiService
    {
        Task<List<string>> GenerateQuestionsAsync(string targetRole, DifficultyLevel difficulty, int count = 5, CancellationToken cancellationToken = default);
        Task<EvaluationResult> EvaluateAnswerAsync(string targetRole, DifficultyLevel difficulty, string question, string userAnswer, CancellationToken cancellationToken = default);
    }
}
