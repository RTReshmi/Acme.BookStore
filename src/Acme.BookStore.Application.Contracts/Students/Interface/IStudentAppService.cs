using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.BookStore.Students.Interface
{
    public interface IStudentAppService :
        ICrudAppService< //Defines CRUD methods
            StudentDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateStudentDto> //Used to create/update a book
    
    {
    }
}
