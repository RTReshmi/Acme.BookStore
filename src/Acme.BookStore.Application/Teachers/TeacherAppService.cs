using Acme.BookStore.Departments;
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
        IRepository<Department, Guid> deptRepository;
        public TeacherAppService(IRepository<Teacher, Guid> repository,
              IRepository<Department, Guid> deptRepository) : base(repository)
        {
            this.repository = repository;
            this.deptRepository = deptRepository;
        }

        public override Task<PagedResultDto<TeacherDto>> GetListAsync(PagedAndSortedResultRequestDto input)
        {
            return base.GetListAsync(input);
        }
        public async Task<List<Teacher>> GetTeachersListAsync() 
        { 


           var techerList = await repository.GetListAsync();

            var deptList= await deptRepository.GetListAsync();

            techerList.ForEach(teacher => {

                if (teacher.DepartmentId!=null)
                {

                   var dept= deptList.Single(x=>x.Id==teacher.DepartmentId);
                    teacher.department = dept;
                }
            
            });


            return techerList;
        }
    }
}
