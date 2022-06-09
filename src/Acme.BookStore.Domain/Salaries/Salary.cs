using Acme.BookStore.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore.Salaries
{
    public class Salary : AuditedAggregateRoot<Guid>
    { 
        public Guid EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public SalaryType Designation { get; set; }
        public float Amount { get; set; }

    }
}
