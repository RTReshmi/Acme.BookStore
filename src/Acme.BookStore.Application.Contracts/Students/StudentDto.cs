using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Acme.BookStore.Students
{
    public class StudentDto : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }
        public int Standard { get; set; }
        public int ContactNumber { get; set; }
        public string Email { get; set; }
    
    }
}
