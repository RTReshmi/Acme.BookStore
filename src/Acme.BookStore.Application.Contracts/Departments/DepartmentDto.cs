using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Acme.BookStore.Departments
{
    public class DepartmentDto : AuditedEntityDto<Guid>
    {
        public string? Name { get; set; }
        public string? HOD { get; set; }
        public int? StaffNumber { get; set; }
        
    }
}
