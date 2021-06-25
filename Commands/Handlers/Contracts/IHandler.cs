using Library.Commands.Contracts;

namespace Library.Handlers.Contracts
{
    public interface IHandler<CreateBookCommand> where CreateBookCommand : ICommand
    {
        ICommandResult Handle(CreateBookCommand command);
    }
}