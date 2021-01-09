using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamGuysStep1.Models;

namespace TeamGuysStep1.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks ()
        {
            return DataSource();
        }
        public BookModel GetBook (int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }
        public List<BookModel> SearchBook(string title, string author)
        {
            return DataSource().Where(x => x.Title.Contains(title) && x.Author.Contains(author)).ToList();
        }
        private List<BookModel> DataSource()
        {
            return new List<BookModel>() {
              new BookModel() {Id= 1, Title="Book1", Author="Author1" },
              new BookModel() {Id= 2, Title="Book2", Author="Author2" },
              new BookModel() {Id= 3, Title="Book3", Author="Author3" }
            }; 
        }
    }
}
