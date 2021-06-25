using System;
using Library.Entities;

namespace Library.Repositories
{
    public interface IBookRepository
    {
        void Create(Book book);

        void Update(Book book);

        Book GetById(Guid id, string name);
    }
}