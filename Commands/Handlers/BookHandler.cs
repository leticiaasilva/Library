using Flunt.Notifications;
using Library.Commands;
using Library.Commands.Contracts;
using Library.Entities;
using Library.Handlers.Contracts;
using Library.Repositories;

namespace Library.Handlers
{
    public class BookHandler
    {
        private readonly IBookRepository _repository;

        public BookHandler(IBookRepository repository)
        {
            _repository = repository;
        }

        public ICommandResult Handle(CreateBookCommand command)
        {
            command.Validate();

            var book = new Book(command.Name, command.Author, command.RegistrationTimeStamp, command.Category, command.Description);

            _repository.Create(book);

            return new GenericCommandResult(true, "Book created", book.Id);
        }


        public ICommandResult Handle(UpdateBookCommand command)
        {
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult(false, "updated incorrect!", command.Notifications);

            var todo = _repository.GetById(command.Id, command.Name);

            _repository.Update(todo);

            return new GenericCommandResult(true, "book updated", todo);

        }
    }
}