using System;
namespace Store {
  public interface IBookRepository {

      Book[] GetByTitle(string titlePart);
      }
   }
