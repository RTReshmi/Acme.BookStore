using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.BookStore.Teachers.Interface
{
    public interface ITeacherAppService :
        ICrudAppService< //Defines CRUD methods
            TeacherDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateTeacherDto> 
    {
    }
}
