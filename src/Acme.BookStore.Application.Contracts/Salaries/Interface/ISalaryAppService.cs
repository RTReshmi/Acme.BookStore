using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.BookStore.Salaries.Interface
{
    public interface ISalaryAppService :
        ICrudAppService< //Defines CRUD methods
            SalaryDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateSalaryDto> //Used to create/update a book
    {
    }
}
