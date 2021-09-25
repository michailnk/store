
namespace Store {
   public interface IBookRepository {
      Book[] GetAllByTitleOrAuthor (string titleOrAuthorPart);
      Book[] GetAllByIsbn(string isbn);
      }
   }
