using JP.Data;
using JP.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JP.Services
{
    public class BookService : IBookService
    {
        /// <summary>
        /// Объявление переменной для общения с базой данных
        /// </summary>
        private readonly GoodBooksDBContext _db;
        public BookService(GoodBooksDBContext db)
        {
            _db = db;
        }

        /// <summary>
        /// Сервис для добавления книги
        /// </summary>
        /// <param name="book"></param>
        public void AddBook(Book book)
        {
           _db.Add(book);
           _db.SaveChanges();
        }
        
        /// <summary>
        /// Сервис для удаления книги
        /// </summary>
        /// <param name="bookId"></param>
        public void DeleteBook(int bookId)
        {
            var bookToDelete = _db.Books.Find(bookId);
            if (bookToDelete != null) 
            {
                _db.Remove(bookToDelete);
                _db.SaveChanges();
            }
            else {
                throw new InvalidOperationException
              (
              "Нельзя удалить эту книгу!");
            }
            
        }

        /// <summary>
        /// Сервис для просмотра всех книг
        /// </summary>
        /// <returns></returns>
        public List<Book> GetAllBooks()
        {
            return _db.Books.ToList();
        }

        /// <summary>
        /// Сервис для просмотра одной книги
        /// </summary>
        /// <param name="bookId"></param>
        /// <returns></returns>
        public Book GetBook(int bookId)
        {
            return _db.Books.Find(bookId);
        }
    }
}
