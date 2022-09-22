using Microsoft.EntityFrameworkCore;
using System.Text.Json;

using Data;
using Model;

namespace Service;

public class DataService
{
    private BookContext db { get; }

    public DataService(BookContext db) {
        this.db = db;
    }
    /// <summary>
    /// Seeder noget nyt data i databasen hvis det er nødvendigt.
    /// </summary>
    public void SeedData() {
        
        Author author = db.Authors.FirstOrDefault()!;
        if (author == null) {
            author = new Author { Fullname = "Kristian" };
            db.Authors.Add(author);
            db.Authors.Add(new Author { Fullname = "Søren" });
            db.Authors.Add(new Author { Fullname = "Mette" });
        }

        Book book = db.Books.FirstOrDefault()!;
        if (book == null)
        {
            db.Books.Add(new Book { Title = "Harry Potter", Author = author });
            db.Books.Add(new Book { Title = "Ringenes Herre", Author = author });
            db.Books.Add(new Book { Title = "Entity Framework for Dummies", Author = author });
        }

        db.SaveChanges();
    }

    public List<Book> GetBooks() {
        return db.Books.Include(b => b.Author).ToList();
    }

    public Book GetBook(int id) {
        return db.Books.Include(b => b.Author).FirstOrDefault(b => b.BookId == id);
    }

    public List<Author> GetAuthors() {
        return db.Authors.ToList();
    }

    public Author GetAuthor(int id) {
        return db.Authors.Include(a => a.Books).FirstOrDefault(a => a.AuthorId == id);
    }

    public string CreateBook(string title, int authorId) {
        Author author = db.Authors.FirstOrDefault(a => a.AuthorId == authorId);
        db.Books.Add(new Book { Title = title, Author = author });
        db.SaveChanges();
        return "Book created";
    }

}