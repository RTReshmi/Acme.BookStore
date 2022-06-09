using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Acme.BookStore.Employees
{
    public class CreateUpdateEmployeeDto
    {
        [Required]
        [StringLength(128)]
        public string Name { get; set; }
        public int Age { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public int ContactNumber { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Designation { get; set; }
    }
}
