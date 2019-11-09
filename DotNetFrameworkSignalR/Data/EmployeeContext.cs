using DotNetFrameworkSignalR.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DotNetFrameworkSignalR.Data
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext() : base("dbConnectionString")
        {
            Database.SetInitializer<EmployeeContext>(new CreateDatabaseIfNotExists<EmployeeContext>());         
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}