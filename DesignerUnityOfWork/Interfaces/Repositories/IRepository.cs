namespace DesignerUnityOfWork.Interfaces.Repositories;

public interface IRepository<T> where T : class
{
    Task<IEnumerable<T>> GetAll();
    Task<T?> GetById(int id);
    Task<T?> Create(T entity);
    void Delete(T entity);
    void Update(T entity);
}