using System;
using Library.Commands.Entities;
using Library.Enums;

namespace Library.Entities
{
    public class Book
    {
        public Book(string name, string author, DateTime registrationTimeStamp, Category category, string description)
        {
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
    }
}
