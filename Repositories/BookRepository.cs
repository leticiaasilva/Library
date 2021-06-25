using System;
using System.Linq;
using Library.Context;
using Library.Entities;
using Microsoft.EntityFrameworkCore;

namespace Library.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly DataContext _context;

        public BookRepository(DataContext context)
        {
            _context = context;
        }

        public void Create(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public Book GetById(Guid id, string name)
        {
            return _context
                .Books
                .FirstOrDefault(x => x.Id == id && x.Name == name);
        }

        public void Update(Book book)
        {
            _context.Entry(book).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}