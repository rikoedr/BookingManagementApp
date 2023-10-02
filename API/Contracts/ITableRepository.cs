using API.Models;

namespace API.Contracts;

public interface ITableRepository<T>
{
    IEnumerable<T> GetAll();
    T? GetByGuid(Guid guid);
    T? Create(T entity);
    bool Update(T entity);
    bool Delete(T entity);
}
