using Dev_Task.DAL;
using Dev_Task.Models;
using Microsoft.Graph;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace Dev_Task.Controllers
{
    public class HomeController : Controller
    {
        readonly BaseRepo<Book> repo = new BaseRepo<Book>();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult BookSearch()
        {
            return Json(repo.GetAll());
        }

        [HttpPost]
        public ActionResult BookAdd(Book book)
        {
            if (book == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                repo.Add(book);
                return new HttpStatusCodeResult(HttpStatusCode.OK);
            }
        }
        [HttpPost]
        public ActionResult BookDel(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                repo.Delete(id);
                return new HttpStatusCodeResult(HttpStatusCode.OK);
            }
        }
    }
}