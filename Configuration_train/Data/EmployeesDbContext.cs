using Configuration_train.Data.ModelConfigurations;
using Configuration_train.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Configuration_train.Data
{
    public class EmployeesDbContext : DbContext
    {
        public EmployeesDbContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Language> Languages { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new LanguageModelConfiguration());
            modelBuilder.ApplyConfiguration(new CountryModelConfiguration());
            modelBuilder.ApplyConfiguration(new CompanyModelConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeModelConfiguration());
            modelBuilder.ApplyConfiguration(new Employees2CompaniesConfiguration());
            modelBuilder.ApplyConfiguration(new Employees2LanguagesConfiguration());
            modelBuilder.ApplyConfiguration(new Companies2CitiesConfiguration());
        }
    }
}
