using MongoConnect.Models;

namespace MongoConnect.Repositories
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        Task<IList<T>> GetAllAsync();
        Task<T> GetByIdAsync(string id);
        Task<T> AddAsync(T document);
    }
}
