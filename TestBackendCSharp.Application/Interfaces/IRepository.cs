using TestCSharp.Models;

namespace TestCSharp.Interfaces
{
    public interface IRepository<T>
    {
        Task<T> Create(T entidade);
        Task<T> GetById(Guid id);
        Task<T> Update(Guid id, T entidade);
        Task Delete(Guid id);
        IEnumerable<T> Listar();
    }
}
