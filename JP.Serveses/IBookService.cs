using System.Collections.Generic;
using JP.Data.Models;

namespace JP.Services
{
    /// <summary>
    /// Интерфейс книжного сервиса
    /// </summary>
    public interface IBookService
    {
        /// <summary>
        /// Сервис для просмотра всех книг
        /// </summary>
        /// <returns></returns>
        public List<Book> GetAllBooks();

        /// <summary>
        /// Сервис для просмотра одной книги
        /// </summary>
        /// <param name="bookId"></param>
        /// <returns></returns>
        public Book GetBook(int bookId);

        /// <summary>
        /// Сервис для добавления книги
        /// </summary>
        /// <param name="book"></param>
        public void AddBook(Book book);

        /// <summary>
        /// Сервис для удаления книги
        /// </summary>
        /// <param name="bookId"></param>
        public void DeleteBook(int bookId);
    }
}