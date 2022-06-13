using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Acme.BookStore.Book_Authors
{
    public class CreateUpdateBook_AuthorDto
    {
        [Required]
        public Guid BookId { get; set; }
        [Required]
        public Guid AuthorId { get; set; }

    }
}
