


using Acme.BookStore.Books;
using Acme.BookStore.Students.Interface;
using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.Students
{
    public class StudentAppService :
        CrudAppService<
            Student, //The Book entity
            StudentDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateStudentDto>, //Used to create/update a book
        IStudentAppService //implement the IBookAppService
    {
        private readonly IRepository<Student, Guid> studentRepository;
        private readonly IRepository<Book, Guid> bookRepository;
        public StudentAppService(IRepository<Student, Guid> studentRepository) : base(studentRepository)
        {
            this.studentRepository = studentRepository;
            this.bookRepository = bookRepository;
        }


        public async void AddBookAndStudent(StudentAndBookDto obj)
        {
            var bookEntity = ObjectMapper.Map<BookDto, Book>(obj.BookDto);

            var studentEntity = ObjectMapper.Map<StudentDto, Student>(obj.StudentDto);
            try
            {
                // 2 repository
            

                // book inserting
                await bookRepository.InsertAsync(bookEntity,true);
                await studentRepository.InsertAsync(studentEntity,true);
            }
            catch (Exception ex)
            {
                var createUpdateDto=ObjectMapper.Map<StudentDto, CreateUpdateStudentDto>(obj.StudentDto);
                var x=await base.CreateAsync(createUpdateDto);
            }

        }

        public override Task<StudentDto> CreateAsync(CreateUpdateStudentDto input)
        {
            return base.CreateAsync(input);
        }
    }


    public class StudentAndBookDto
    {
        public StudentDto StudentDto { get; set; }
        public BookDto BookDto { get; set; }
    }
}
