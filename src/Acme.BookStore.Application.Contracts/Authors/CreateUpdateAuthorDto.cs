using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Acme.BookStore.Authors
{
    public class CreateUpdateAuthorDto
    {
        
        [Required]
        public string Name { get; set; }
        public string PenName { get; set; }
    }
}
