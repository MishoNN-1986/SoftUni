using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EfCodeF.Infrastructure.Data
{
    /// <summary>
    /// Публикация
    /// </summary>
    // коментара се генерира през xml
    [Table ("Posts")] // за да е в многжествено число таблицата в базата данни(sql си го прави автоматично)
    public class Post
    {
        /// <summary>
        /// Идентификатор на запис
        /// </summary>
        [Key]
        [Column ("Id")] // как да е името на таблицата
        public int PostId { get; set; }

        /// <summary>
        /// Автор на публикацията
        /// </summary>
        public int? AuthorId { get; set; }

        /// <summary>
        /// Заглавие
        /// </summary>
        [Required]
        [StringLength(250, MinimumLength = 10)]
        public string Title { get; set; }

        /// <summary>
        /// Съдържание
        /// </summary>
        [Required]
        public string Content { get; set; }

        /// <summary>
        /// Автор на публикацията
        /// </summary>
        [ForeignKey(nameof(AuthorId))] // прави го на string (пропартито, което държи id-то)
        public User Author { get; set; }
        
    }
}
