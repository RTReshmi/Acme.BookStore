using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Acme.BookStore.Teachers
{
    public class CreateUpdateTeacherDto
    {
        [Required]
        [StringLength(128)]
        public string Name { get; set; }
        [Required]
        public string ContactNumber { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public Guid DepartmentId { get; set; }
    }
}
