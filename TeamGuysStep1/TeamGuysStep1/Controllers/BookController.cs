using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TeamGuysStep1.Models;
using TeamGuysStep1.Repository;

namespace TeamGuysStep1.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;

        public BookController()
        {
            _bookRepository = new BookRepository();
        }
        public ViewResult GetAllBooks()
        {
            var _data = _bookRepository.GetAllBooks();
            return View(_data);
        }
        public BookModel GetBook (int id)
        {
            return _bookRepository.GetBook(id);
        }
        public List<BookModel> SearchBook(string title, string author)
        {
            return _bookRepository.SearchBook(title, author);
        }
    }
}
