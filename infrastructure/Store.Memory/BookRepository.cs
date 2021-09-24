using System.Linq;

namespace Store.Memory {
   public class BookRepository : IBookRepository {
      public Book[] GetByTitle(string titlePart) {
         return books.Where(book => book.Title.Contains(titlePart)).ToArray();
         }
      private readonly Book[] books = new Book[] {
            new Book(1, "Art of Programming"),
            new Book(2,"Refactoring"),
            new Book(3, "C Programming language")
         };
      }
   }
