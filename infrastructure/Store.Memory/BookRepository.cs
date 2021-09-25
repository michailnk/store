using System.Linq;

namespace Store.Memory {
   public class BookRepository : IBookRepository {
      public Book[] GetAllByTitleOrAuthor(string titlePart) {
         return books.Where(book => book.Title.Contains(titlePart)).ToArray();
         }
      private readonly Book[] books = new Book[] {
            new Book(1,"ISBN 12345-23456","D Knuth", "Art of Programming"),
            new Book(2, "ISBN 12345-23458","M/ Flower","Refactoring"),
            new Book(3, "ISBN 12345-23459","Kernighan, Ritchie","C Programming language")
         };
      }
   }
 