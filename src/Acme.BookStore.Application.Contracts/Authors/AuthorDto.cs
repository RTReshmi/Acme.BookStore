using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Acme.BookStore.Authors
{
    public class AuthorDto : AuditedEntityDto<Guid>
    {
        
        public string Name { get; set; }
        public string PenName { get; set; }
    }
}
