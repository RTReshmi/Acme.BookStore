using Acme.BookStore.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore.Marks
{
    public class Mark: AuditedAggregateRoot<Guid>
    {
        public Guid StudentId { get; set; }
        public string ExamName { get; set; }
        public float Mark1 { get; set; }
        public float Mark2 { get; set; }
        public virtual Student Student { get; set; }

    }
}
