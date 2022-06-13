using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.BookStore.Marks.Interface
{
    public interface IMarkAppService :
        ICrudAppService< 
            MarkDto, 
            Guid, 
            PagedAndSortedResultRequestDto, 
            CreateUpdateMarkDto>  
    {
    }
}
