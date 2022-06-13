using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.BookStore.Book_Authors.Interface
{
    public interface IBook_AuthorAppService :
        ICrudAppService< 
            Book_AuthorDto, 
            Guid, 
            PagedAndSortedResultRequestDto, 
            CreateUpdateBook_AuthorDto> 
    {
    }
}
