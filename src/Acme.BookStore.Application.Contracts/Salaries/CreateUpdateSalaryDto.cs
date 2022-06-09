using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Acme.BookStore.Salaries
{
   public class CreateUpdateSalaryDto
    {
        [Required]
        public Guid EmployeeId { get; set; }
        [Required]
        [StringLength(128)]
        public string EmployeeName { get; set; }
        [Required]
        public SalaryType Designation { get; set; } = SalaryType.Undefined;
        [Required]
        public float Amount { get; set; }

    }
}
