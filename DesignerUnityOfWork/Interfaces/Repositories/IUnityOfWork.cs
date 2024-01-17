namespace DesignerUnityOfWork.Interfaces.Repositories;
public interface IUnityOfWork : IDisposable
{
    Task Commit();
}
