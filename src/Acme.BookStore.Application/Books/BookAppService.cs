using Acme.BookStore.Books.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.Books
{
    public class BookAppService: 
        CrudAppService<
            Book, //The Book entity
            BookDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateBookDto>, //Used to create/update a book
        IBookAppService //implement the IBookAppService
    {
        private readonly IRepository<Book, Guid> repository;
        public BookAppService(IRepository<Book, Guid> repository)
            : base(repository)
        {
            this.repository = repository;
        }

        public override Task<BookDto> CreateAsync(CreateUpdateBookDto input)
        {
            int a = 10;

            return base.CreateAsync(input);
        }

        public override Task<PagedResultDto<BookDto>> GetListAsync(PagedAndSortedResultRequestDto input)
        {


            return base.GetListAsync(input);
        }

        public override Task<BookDto> UpdateAsync(Guid id, CreateUpdateBookDto input)
        {


            return base.UpdateAsync(id, input);
        }

       
        
        public int GetData(int x)
        {

            return 12;
        }


        [ActionName("AddBook"), HttpPost]
        public async Task <BookDto> AddBook(BookDto bookDto)
        {

            ///var customerDto = await base.CreateAsync(input); // customer

            //var newCustomer = ObjectMapper.Map<CreateUpdateCustomerDto, Customer>(input);
            //var customer = await _customerRepository.InsertAsync(newCustomer, true);


            var bookEntity = ObjectMapper.Map<BookDto, Book>(bookDto);


            await repository.InsertAsync(bookEntity);
            var _bookDto = ObjectMapper.Map<Book, BookDto>(bookEntity);

            return _bookDto;




        }
        [ActionName("GetBookByName"), HttpPost]
        public async Task<BookDto>GetBook (string name)
        {
            //get data from Db
            try
            {

                var selectedBook = await repository.SingleAsync(x => x.Name == name);
                var _bookDto = ObjectMapper.Map<Book, BookDto>(selectedBook);

                return _bookDto; 
            }
            catch (Exception ex)
            {

                throw;
            }
            return null;



            




        }


    }
    
    
}
