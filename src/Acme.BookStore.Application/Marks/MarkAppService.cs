using Acme.BookStore.Marks.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.Marks
{
    public class MarkAppService :
        CrudAppService<
            Mark,
            MarkDto,
            Guid,
            PagedAndSortedResultRequestDto,
            CreateUpdateMarkDto>,
        IMarkAppService
    {
        public MarkAppService(IRepository<Mark, Guid> repository) : base(repository)
        {
        }
    }
}
