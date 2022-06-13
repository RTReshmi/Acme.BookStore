using Acme.BookStore.Books_Authors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore.Authors
{
    public class Author:AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
        public string PenName { get; set; }
        public ICollection<Book_Author> Book_Authors { get; set; }
    }
}
