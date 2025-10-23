namespace CatchUpPlatform.API.shared.domain.Repositories;

public interface IUnitOfWork
{
    Task CompleteAsync();
}