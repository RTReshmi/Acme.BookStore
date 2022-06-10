using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Acme.BookStore.Departments
{
    public class CreateUpdateDepartmentDto
    {
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? HOD { get; set; }
        [Required]
        public int? StaffNumber { get; set; }
    }
}
