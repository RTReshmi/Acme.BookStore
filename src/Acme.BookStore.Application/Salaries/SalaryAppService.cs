using Acme.BookStore.Salaries.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.Salaries
{
    public class SalaryAppService :
            CrudAppService<
            Salary, //The Book entity
            SalaryDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateSalaryDto>, //Used to create/update a book
            ISalaryAppService
    {
        public SalaryAppService(IRepository<Salary, Guid> repository) : base(repository)
        {
        }
    }
}
