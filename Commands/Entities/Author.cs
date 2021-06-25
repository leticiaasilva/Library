using System;
using System.Diagnostics;

namespace Library.Commands.Entities
{
    public class Author
    {
        public Author()
        {
        }

        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}
