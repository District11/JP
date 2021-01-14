using System;
using System.Collections.Generic;
using System.Text;

namespace JP.Data.Models
{
    /// <summary>
    /// Модель обзора книги
    /// </summary>
    public class BookReview
    {
        /// <summary>
        /// идентификатор обозреваемой книги
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Обзор автора книги
        /// </summary>
        public string ReviewAuthor { get; set; }

        /// <summary>
        /// Обзор контента книги
        /// </summary>
        public string ReviewContent { get; set; }

        /// <summary>
        /// Дата создания книги
        /// </summary>
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// Дата изменения книги
        /// </summary>
        public DateTime Updatedon { get; set; }

        public Book Book { get; set; }
    }
}
