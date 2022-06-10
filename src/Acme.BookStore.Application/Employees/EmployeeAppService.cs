using Acme.BookStore.Employees.Interface;
using Acme.BookStore.Salaries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.Employees
{
    public class EmployeeAppService :
        CrudAppService<
            Employee, //The Book entity
            EmployeeDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateEmployeeDto>, //Used to create/update a book
            IEmployeeAppService //implement the IBookAppService
    {
        private readonly IRepository<Employee, Guid> employeerepository;
        private readonly IRepository<Salary, Guid> _salaryrepository;
        public EmployeeAppService(IRepository<Employee, Guid> employeerepository) : base(employeerepository)
        {
           this. employeerepository = employeerepository;
            //_salaryrepository = salaryrepository;


        }
        public void AddEmployeeAndSalary(SalaryAndEmployee obj)
        {
            var employeeentity= ObjectMapper.Map<EmployeeDto, Employee>(obj.EmployeeDto);

        }


        public class SalaryAndEmployee
        {
          public EmployeeDto EmployeeDto { get; set; }
          public SalaryDto SalaryDto { get; set; }

        }

        
    }
}
