using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Web;

namespace HomeLibrary.Models
{
    public class Book
    {
        [Display(Name = "Book's author:")]
        [Required(ErrorMessage = "Author required!")]
        public string Author { get; set; }

        [Display(Name = "Book's name:")]
        [Required(ErrorMessage = "Book's name required!")]
        public string Name { get; set; }


        
    }
}