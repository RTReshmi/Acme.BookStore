﻿using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Acme.BookStore.Teachers
{
    public class TeacherDto : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public Guid DepartmentId { get; set; }
    }
}
