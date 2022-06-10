
using Acme.BookStore.Departments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore.Teachers
{
    public class Teacher : AuditedAggregateRoot<Guid>
    {
        
        
        public Guid ?DepartmentId { get; set; }
        public virtual Department? department { get; set; }


        public string Name { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
    }
}
