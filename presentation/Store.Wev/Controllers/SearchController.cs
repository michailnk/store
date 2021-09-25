using Microsoft.AspNetCore.Mvc;
using Store.Memory;

namespace Store.Web {
   public class SearchController : Controller {
      //private readonly IBookRepository bookRepository;
      private readonly BookService  bookService ;
      public SearchController(IBookRepository bookRepository) {
         this.bookService = bookService;
         }

      public IActionResult Index(string query) {
         var books = bookService.GetAllByQuery(query);
         return View(books);

         }
      }
   }
