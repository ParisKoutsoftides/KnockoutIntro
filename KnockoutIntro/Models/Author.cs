using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace KnockoutIntro.Models
{
    public class Author
    {
       public int Id { get; set; }

       [Required]
       public string FirstName { get; set; }

       [Required]
       public string LastName { get; set; }

       public string Biography { get; set; }

       public virtual ICollection<Book> Books { get; set; }

    }
}
