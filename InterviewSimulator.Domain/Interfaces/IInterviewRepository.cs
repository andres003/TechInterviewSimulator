using InterviewSimulator.Domain.Entities;

namespace InterviewSimulator.Domain.Interfaces
{
    public interface IInterviewRepository
    {
        Task AddSessionAsync(InterviewSession session, CancellationToken cancellationToken = default);
        Task<InterviewSession?> GetSessionByIdAsync(Guid id, CancellationToken cancellationToken = default);
        Task<List<InterviewSession>> GetAllSessionsAsync(CancellationToken cancellationToken = default);
        Task SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
