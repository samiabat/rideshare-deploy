
namespace Rideshare.Application.Contracts.Persistence;

public interface IUnitOfWork : IDisposable
{
    ITestEntityRepository TestEntityRepository { get; }
    IFeedbackRepository FeedbackRepository { get; }
    Task<int> Save(); 
}
