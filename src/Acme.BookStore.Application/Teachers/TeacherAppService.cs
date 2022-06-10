using Acme.BookStore.Teachers.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.Teachers
{
    public class TeacherAppService :
        CrudAppService<
            Teacher, //The Book entity
            TeacherDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateTeacherDto>, //Used to create/update a book
            ITeacherAppService
    {
        IRepository<Teacher, Guid> repository;
        public TeacherAppService(IRepository<Teacher, Guid> repository) : base(repository)
        {
            this.repository = repository;
        }

        public override Task<PagedResultDto<TeacherDto>> GetListAsync(PagedAndSortedResultRequestDto input)
        {
            return base.GetListAsync(input);
        }
        public List<TeacherDto>GetTeachersList()
        {
            repository.GetListAsync(repository.)
        }
    }
}
