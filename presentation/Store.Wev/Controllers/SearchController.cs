using Microsoft.AspNetCore.Mvc;
using Store.Memory;

namespace Store.Web {
   public class SearchController : Controller {
      private readonly IBookRepository bookRepository;
      public SearchController(IBookRepository bookRepository) {
         this.bookRepository = bookRepository;
         }

      public IActionResult Index(string query) {
         var books = bookRepository.GetAllByTitle(query);
         return View(books);

         }
      }
   }
 