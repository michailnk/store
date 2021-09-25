using System;

namespace Store {
   public class BookService
    {
      private readonly IBookRepository bookrepository;
      public BookService(IBookRepository bookrepository) {
         this.bookrepository = bookrepository;
         }

      public Book[] GetAllByQuery(string query) {
         if(Book.IsIsbn(query))
            return bookrepository.GetAllByIsbn(query);
          return bookrepository.GetAllByTitleOrAuthor(query);
         }
    }
}
