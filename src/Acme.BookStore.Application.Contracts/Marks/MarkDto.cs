using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Acme.BookStore.Marks
{
    public class MarkDto : AuditedEntityDto<Guid>
    {
        public Guid StudentId { get; set; }
        public string ExamName { get; set; }
        public float Mark1 { get; set; }
        public float Mark2 { get; set; }
        
    }
}
