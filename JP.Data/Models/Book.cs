using System;
using System.Collections.Generic;
using System.Text;

namespace JP.Data.Models
{
    /// <summary>
    /// Модель Книги
    /// </summary>
   public class Book
    {
        /// <summary>
        /// Идентификатор книги
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// Название книги
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Автор книги
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Дата создания книги
        /// </summary>
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// Дата изменения книги
        /// </summary>
        public DateTime Updatedon { get; set; }
    }
}
