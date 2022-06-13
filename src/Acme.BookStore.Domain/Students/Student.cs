using Acme.BookStore.Marks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore.Students
{
    public class Student: AuditedAggregateRoot<Guid>
    {
        public string Name{get; set;}
        public int Standard{get; set;}
        public int ContactNumber{get; set;}
        public string Email{get; set;}
        
        public virtual ICollection<Mark>? StudentMarks { get; set; } = new List<Mark>();
    }
}
