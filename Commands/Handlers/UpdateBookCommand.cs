using System;
using Flunt.Notifications;
using Flunt.Validations;
using Library.Commands.Contracts;
using Library.Enums;

namespace Library.Commands
{
    public class UpdateBookCommand : Notifiable, ICommand
    {
        public UpdateBookCommand() { }

        public UpdateBookCommand(Guid id, string name, string author, DateTime registrationTimeStamp, Category category, string description)
        {
            Id = id;
            Name = name;
            Author = author;
            RegistrationTimeStamp = registrationTimeStamp;
            Category = category;
            Description = description;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public DateTime RegistrationTimeStamp { get; set; }
        public Category Category { get; set; }
        public string Description { get; set; }


        public void Validate()
        {
            AddNotifications(
                new Contract()
                    .Requires()
                    .HasMinLen(Name, 6, "Name", "Invalid! Name")
            );
        }
    }
}