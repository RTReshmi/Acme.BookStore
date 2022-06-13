using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Acme.BookStore.Book_Authors
{
    public class Book_AuthorDto : AuditedEntityDto<Guid>
    {
        public Guid ?BookId { get; set; }
        public Guid ?AuthorId { get; set; }
        
    }
}
