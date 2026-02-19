using Books.Api.Interfaces;
using Books.Api.Models;
using System.Collections.Generic;

namespace Books.Api.Data
{
    public class AuthorRepository : IAuthorRepository
    {
        public List<Author> GetAll()
        {
            return new List<Author>
            {
                new Author { Id = 1, FirstName = "Harper", LastName = "Lee", Company = "J.B. Lippincott & Co." },
                new Author { Id = 2, FirstName = "Yuval Noah", LastName = "Harari", Company = "Harvill Secker" },
                new Author { Id = 3, FirstName = "Stieg", LastName = "Larsson", Company = "Norstedts Förlag" },
                new Author { Id = 4, FirstName = "J.R.R.", LastName = "Tolkien", Company = "George Allen & Unwin" },
                new Author { Id = 5, FirstName = "Frank", LastName = "Herbert", Company = "Chilton Books" },
                new Author { Id = 6, FirstName = "Anne", LastName = "Frank", Company = "Contact Publishing" },
                new Author { Id = 7, FirstName = "Jane", LastName = "Austen", Company = "T. Egerton" },
                new Author { Id = 8, FirstName = "Dan", LastName = "Brown", Company = "Doubleday" },
                new Author { Id = 9, FirstName = "Bram", LastName = "Stoker", Company = "Archibald Constable and Company" },
                new Author { Id = 10, FirstName = "Anthony", LastName = "Doerr", Company = "Scribner" },
                new Author { Id = 11, FirstName = "J.D.", LastName = "Salinger", Company = "Little, Brown and Company" },
                new Author { Id = 12, FirstName = "Tara", LastName = "Westover", Company = "Random House" },
                new Author { Id = 13, FirstName = "Gillian", LastName = "Flynn", Company = "Crown Publishing Group" },
                new Author { Id = 14, FirstName = "J.K.", LastName = "Rowling", Company = "Bloomsbury" },
                new Author { Id = 15, FirstName = "Orson Scott", LastName = "Card", Company = "Tor Books" },
                new Author { Id = 16, FirstName = "Walter", LastName = "Isaacson", Company = "Simon & Schuster" },
                new Author { Id = 17, FirstName = "Jojo", LastName = "Moyes", Company = "Penguin Books" },
                new Author { Id = 18, FirstName = "Alex", LastName = "Michaelides", Company = "Celadon Books" },
                new Author { Id = 19, FirstName = "Stephen", LastName = "King", Company = "Doubleday" },
                new Author { Id = 20, FirstName = "Markus", LastName = "Zusak", Company = "Picador" }
            };
        }
    }
}
