using SimpleBookCatalog.Domain.Entities;

namespace SimpleBookCatalog.Application.Interfaces
{
    public interface IBookRepository
    {
        Task<bool> AddAsync(Book book);
        Task<List<Book>> GetAllAsync();
        Task<bool> DeleteByIdAsync(int id);
        Task<bool> UpdateAsync(Book book);
        Task<Book?> GetByIdAsync(int id);
    }

}
