using Acme.BookStore.Books;
using Acme.BookStore.Students;
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
            //CreateMap<CreateUpdateStudentDto, Student>().ReverseMap();
        
    }
}
