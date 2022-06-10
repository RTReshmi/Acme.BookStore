using Acme.BookStore.Teachers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore.Departments
{
    public class Department : AuditedAggregateRoot<Guid>
    {
        public string? Name { get; set; }
        public string? HOD { get; set; }
        public int? StaffNumber { get; set; }
        public virtual Teacher? teacher { get; set; }


    }
}
