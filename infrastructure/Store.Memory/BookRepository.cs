using System.Linq;

namespace Store.Memory {
   public class BookRepository : IBookRepository {
      public Book[] GetAllByTitleOrAuthor(string query) {
         return books.Where(book => book.Title.Contains(query)
                                   || book.Author.Contains(query)).ToArray();
         }

      public Book[] GetAllByIsbn(string isbn) {
         return books.Where(book=>book.Isbn==isbn).ToArray();
         }

      private readonly Book[] books = new Book[] {
            new Book(1,"ISBN 12345-23456","D. Knuth", "Art of Programming"),
            new Book(2, "ISBN 12345-23458","M. Flower","Refactoring"),
            new Book(3, "ISBN 12345-23459","Kernighan, Ritchie","C Programming language")
         };
      }
   }
 