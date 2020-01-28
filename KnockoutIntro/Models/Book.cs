using System;
using System.ComponentModel.DataAnnotations;

namespace KnockoutIntro.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Isbn { get; set; }

        public string Synopsis { get; set; }

        public string Description { get; set; }

        [RegularExpression(@"(https?:\/\/(?:www\.|(?!www))[a-zA-Z0-9][a-zA-Z0-9-]+[a-zA-Z0-9]\.[^\s]{2,}|www\.[a-zA-Z0-9][a-zA-Z0-9-]+[a-zA-Z0-9]\.[^\s]{2,}|https?:\/\/(?:www\.|(?!www))[a-zA-Z0-9]+\.[^\s]{2,}|www\.[a-zA-Z0-9]+\.[^\s]{2,})")]
        public string ImageUrl { get; set; }

        [Required]
        public virtual Author author { get; set; }

        [Required]
        public int AuthorId { get; set; }

    }
}
