using Microsoft.EntityFrameworkCore;
using SimpleBookCatalog.Application.Interfaces;
using SimpleBookCatalog.Domain.Entities;
using SimpleBookCatalog.Infrastructure.Context;

namespace SimpleBookCatalog.Infrastructure.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly SimpleBookCatalogDbContext _context;
        public BookRepository(IDbContextFactory<SimpleBookCatalogDbContext> factory) 
        {
            _context = factory.CreateDbContext();
        }
        public async Task<bool> AddAsync(Book book)
        {
            _context.Books.Add(book);
            int res = await _context.SaveChangesAsync();
            return res > 0 ? true : false;
        }
        public async Task<List<Book>> GetAllAsync()
        {
            List<Book> books = await _context.Books.ToListAsync<Book>();
            return books;
        }
        public async Task<bool> DeleteByIdAsync(int id)
        {
            var book = await _context.Books.FindAsync(id);
            if (book == null)
                return false;
            _context.Books.Remove(book);
            int res = await _context.SaveChangesAsync();
            return res > 0;
        }
        public async Task<bool> UpdateAsync(Book book)
        {
            var existingBook = await _context.Books.FindAsync(book.Id);
            if (existingBook == null)
                return false;
            _context.Entry(existingBook).CurrentValues.SetValues(book);
            int res = await _context.SaveChangesAsync();
            return res > 0;
        }
        public async Task<Book?> GetByIdAsync(int id)
        {
            return await _context.Books.FindAsync(id);
        }
    }
}
