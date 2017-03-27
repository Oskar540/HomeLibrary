using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using HomeLibrary.Models;
using System.Xml.Linq;

namespace HomeLibrary.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index(string author, string name)
        {
            List<Book>books = new List<Book>();
            books.Add(new Book{ Author = author, Name = name});

            XDocument doc = new XDocument(
                new XElement("book",
                    new XElement("author", author),
                    new XElement("name", name))
            );
            doc.Save("BooksData.xml"); //error sciezka dostepu

            //Zapisywanie parametrow author i name w pliku BooksData.xml jako nowy obiekt book

            return View();
        }
        
    }
}