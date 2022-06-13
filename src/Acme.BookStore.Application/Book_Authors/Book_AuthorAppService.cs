using Acme.BookStore.Book_Authors.Interface;
using Acme.BookStore.Books_Authors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.Book_Authors
{
    public class Book_AuthorAppService :
        CrudAppService<
            Book_Author,
            Book_AuthorDto,
            Guid,
            PagedAndSortedResultRequestDto,
            CreateUpdateBook_AuthorDto>,
        IBook_AuthorAppService
    {
        public Book_AuthorAppService(IRepository<Book_Author, Guid> repository) : base(repository)
        {
        }
    }
}
