using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Security.Permissions;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using HomeLibrary.Models;
using System.Xml.Linq;
using Microsoft.Ajax.Utilities;

namespace HomeLibrary.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index(string author, string name)
        {
            List<Book>books = new List<Book>();
            books.Add(new Book{ Author = author, Name = name});

            XDocument doc = new XDocument(
                new XElement("bookstore",
                new XElement("book", 
                    new XElement("author", author),
                    new XElement("name", name)))
            );

            string pathfile =
                @"C:\users\oskar\documents\visual studio 2015\projects\homelibrary\homelibrary\app_data\booksdata.xml";
            var permissionSet = new PermissionSet(PermissionState.None);
            var writePermission = new FileIOPermission(FileIOPermissionAccess.Write, pathfile);
            permissionSet.AddPermission(writePermission);

            if (permissionSet.IsSubsetOf(AppDomain.CurrentDomain.PermissionSet))
            {
                doc.Save(pathfile);
            }
            
            return View();
        }
        
    }
}