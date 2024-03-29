﻿using Acme.BookStore.Authors;
using Acme.BookStore.Books;
using Acme.BookStore.Books_Authors;
using Acme.BookStore.Departments;
using Acme.BookStore.Employees;
using Acme.BookStore.Marks;
using Acme.BookStore.Salaries;
using Acme.BookStore.Students;
using Acme.BookStore.Teachers;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.IdentityServer.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.TenantManagement;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace Acme.BookStore.EntityFrameworkCore;

[ReplaceDbContext(typeof(IIdentityDbContext))]
[ReplaceDbContext(typeof(ITenantManagementDbContext))]
[ConnectionStringName("Default")]
public class BookStoreDbContext :
    AbpDbContext<BookStoreDbContext>,
    IIdentityDbContext,
    ITenantManagementDbContext
{
    /* Add DbSet properties for your Aggregate Roots / Entities here. */
    public DbSet<Book> Books { get; set; }
    public DbSet<Student> Students { get; set; }

    public DbSet<Employee>Employees { get; set; }
    public DbSet<Salary> Salaries { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Mark> Marks { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Book_Author> Book_Authors { get; set; }



    #region Entities from the modules

    /* Notice: We only implemented IIdentityDbContext and ITenantManagementDbContext
     * and replaced them for this DbContext. This allows you to perform JOIN
     * queries for the entities of these modules over the repositories easily. You
     * typically don't need that for other modules. But, if you need, you can
     * implement the DbContext interface of the needed module and use ReplaceDbContext
     * attribute just like IIdentityDbContext and ITenantManagementDbContext.
     *
     * More info: Replacing a DbContext of a module ensures that the related module
     * uses this DbContext on runtime. Otherwise, it will use its own DbContext class.
     */

    //Identity
    public DbSet<IdentityUser> Users { get; set; }
    public DbSet<IdentityRole> Roles { get; set; }
    public DbSet<IdentityClaimType> ClaimTypes { get; set; }
    public DbSet<OrganizationUnit> OrganizationUnits { get; set; }
    public DbSet<IdentitySecurityLog> SecurityLogs { get; set; }
    public DbSet<IdentityLinkUser> LinkUsers { get; set; }

    // Tenant Management
    public DbSet<Tenant> Tenants { get; set; }
    public DbSet<TenantConnectionString> TenantConnectionStrings { get; set; }

    #endregion

    public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        /* Include modules to your migration db context */

        builder.ConfigurePermissionManagement();
        builder.ConfigureSettingManagement();
        builder.ConfigureBackgroundJobs();
        builder.ConfigureAuditLogging();
        builder.ConfigureIdentity();
        builder.ConfigureIdentityServer();
        builder.ConfigureFeatureManagement();
        builder.ConfigureTenantManagement();

        /* Configure your own tables/entities inside here */

        builder.Entity<Book>(b =>
        {
            
            b.Property(x => x.Name).IsRequired().HasMaxLength(128);
        });
        builder.Entity<Student>(b =>
        {

            b.Property(x => x.Name).IsRequired().HasMaxLength(128);
        });
        builder.Entity<Employee>(b =>
        {

            b.Property(x => x.Name).IsRequired().HasMaxLength(128);
        });
        builder.Entity<Salary>(b =>
        {

            b.Property(x => x.EmployeeName).IsRequired().HasMaxLength(128);
        });


        //one to one
        var teacher = builder.Entity<Teacher>();
       
        teacher.HasOne(x => x.department)
            .WithOne(x => x.teacher)
            .HasForeignKey<Teacher>(x => x.DepartmentId);

        //one to many


        var studentMark = builder.Entity<Mark>();
        studentMark.HasOne(x => x.Student)
            .WithMany(x => x.StudentMarks)
            .HasForeignKey(x => x.StudentId);

        //many to many

        var book_author = builder.Entity<Book_Author>();

        book_author.HasOne(x => x.Book)
            .WithMany(x => x.Book_Authors)
            .HasForeignKey(x => x.BookId);

        book_author.HasOne(x => x.Author)
            .WithMany(x => x.Book_Authors)
            .HasForeignKey(x => x.AuthorId);

    }
}

