using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Acme.BookStore.Students
{
    public class CreateUpdateStudentDto
    {
        [Required]
        [StringLength(128)]
        public string Name { get; set; }
        [Required]
        public int Standard { get; set; }
        [Required]
       
        public int ContactNumber { get; set; }
        [Required]
        public string Email { get; set; }

    }
}
