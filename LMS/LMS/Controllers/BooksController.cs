using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LMS.Models;

namespace LMS.Controllers
{
    public class BooksController : Controller
    {
        // GET: Books
        public ActionResult Random()
        {
            var book = new Book() { BookName = "Harry Potter" };
            return View(book);
        }
    }
}