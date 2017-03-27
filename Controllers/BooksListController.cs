using HomeLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

namespace HomeLibrary.Controllers
{
    public class BooksListController : Controller
    {
        // GET: BooksList
        public ActionResult Index()
        {
            
            return View();
        }
    }
}