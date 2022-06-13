using Acme.BookStore.Authors;
using Acme.BookStore.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore.Books_Authors
{
    public class Book_Author : AuditedAggregateRoot<Guid>
    {
        public Guid BookId { get; set; }
        public Guid AuthorId { get; set; }
        public Book Book { get; set; }
        public Author Author { get; set; }
    }
}
