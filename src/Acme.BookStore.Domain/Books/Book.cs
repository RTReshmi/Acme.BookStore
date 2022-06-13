using Acme.BookStore.Books_Authors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore.Books
{
    public class Book : AuditedAggregateRoot<Guid>
    {
        public string ?Name { get; set; }

        public BookType ?Type { get; set; }

        public DateTime ?PublishDate { get; set; }

        public float ?Price { get; set; }
        public ICollection<Book_Author> ?Book_Authors { get; set; }


    }
}
