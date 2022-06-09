using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Acme.BookStore.Employees
{
    public class EmployeeDto: AuditedEntityDto<Guid>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public int ContactNumber { get; set; }
        public string Email { get; set; }

        public string Designation { get; set; }
    }
}
