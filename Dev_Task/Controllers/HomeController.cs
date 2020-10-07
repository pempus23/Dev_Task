using Dev_Task.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Dev_Task.Controllers
{
    public class HomeController : Controller
    {
        static public IEnumerable<Book> books = new List<Book>
        {
           new Book {
               Id = 1,
               Name = "Robocop",
               ReaderType = Type.Adults,
               Author = "dd",
               Genre = "dd",
               NumberOfPages = 130,
               Description = "dd"               
           },
           new Book {
               Id = 2,
               Name = "Spiderman",
               ReaderType = Type.Children,
               Author = "asd",
               Genre = "asd",
               NumberOfPages = 80,
               Description = "asd"
           },
        };
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult BookSearch()
        {
            return Json(books);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}