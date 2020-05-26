using Configuration_train.Data;
using Configuration_train.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Configuration_train.ModelViews
{
    public class EmployeeViewModel 
    {
        public EmployeeViewModel()
        { }

        public EmployeeViewModel(Employee employee)
        {
            Id = employee.Id;
            FirstName = employee.FirstName;
            SecondName = employee.SecondName;
            Country = new CountryViewModel() { Id = employee.Country.Id, FlagUrl = employee.Country.FlagUrl, CountryName = employee.Country.CountryName };
            Company = new CompanyViewModel() { Id = employee.Company.Id, Name = employee.Company.Name };
            City = new CityViewModel() { Id = employee.City.Id, CityName = employee.City.CityName };
            Languages = employee.Employees2Languages.Select(lang => new LanguageViewModel() { Id = lang.LanguageId, LanguageName = lang.Language.LanguageName }).ToList();
            CompaniesHistory = employee.Employees2Companies.Select(comp => new CompanyViewModel() { Id = comp.CompanyId, Name = comp.Company.Name }).ToList();
        }

        public static async Task<EmployeeViewModel> CreateViewModelAsync(EmployeesDbContext context, int id) => 
            new EmployeeViewModel(await context.Employees.FirstAsync(e => e.Id == id));
        
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public CountryViewModel Country { get; set; }

        public CompanyViewModel Company { get; set; }

        public CityViewModel City { get; set; }

        public List<LanguageViewModel> Languages { get; set; }

        public List<CompanyViewModel> CompaniesHistory { get; set; }
    }
}
