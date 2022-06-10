using Acme.BookStore.Books;
using Acme.BookStore.Departments;
using Acme.BookStore.Employees;
using Acme.BookStore.Salaries;
using Acme.BookStore.Students;
using Acme.BookStore.Teachers;
using AutoMapper;

namespace Acme.BookStore;

public class BookStoreApplicationAutoMapperProfile : Profile
{
    public BookStoreApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

       
            CreateMap<Book, BookDto>().ReverseMap();
            CreateMap<CreateUpdateBookDto, Book>().ReverseMap();
            CreateMap<Student, StudentDto>().ReverseMap();
            CreateMap<CreateUpdateStudentDto, Student>().ReverseMap();
            CreateMap<CreateUpdateStudentDto, StudentDto>().ReverseMap();
            CreateMap<Employee, EmployeeDto>().ReverseMap();
            CreateMap<CreateUpdateEmployeeDto, Employee>().ReverseMap();
            CreateMap<Salary, SalaryDto>().ReverseMap();
            CreateMap<CreateUpdateSalaryDto, Salary>().ReverseMap();
            CreateMap<Teacher, TeacherDto>().ReverseMap();
            CreateMap<CreateUpdateTeacherDto, Teacher>().ReverseMap();
            CreateMap<Department, DepartmentDto>().ReverseMap();
            CreateMap<CreateUpdateDepartmentDto, Department>().ReverseMap();





    }
}
