using Acme.BookStore.Employees;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Acme.BookStore.Salaries
{
    public class SalaryDto : AuditedEntityDto<Guid>
    
    {
        public Guid ?EmployeeId { get; set; }
        public string EmployeeName { get; set; }
       public SalaryType Designation { get; set; }
        public float Amount { get; set; }

    }
}
