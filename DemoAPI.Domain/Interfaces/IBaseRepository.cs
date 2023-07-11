
using DemoAPI.Core.Entities;

namespace DemoAPI.Core.Interfaces
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        Task<IList<T>> GetAllAsync();
        Task<T> GetByIdAsync(string id);
        Task<T> AddAsync(T document);
    }
}
