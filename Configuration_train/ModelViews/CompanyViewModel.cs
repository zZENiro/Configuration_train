using Configuration_train.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Configuration_train.ModelViews
{
    public class CompanyViewModel 
    {
        public CompanyViewModel()
        { }

        public CompanyViewModel(Company company)
        {
            Id = company.Id;
            Name = company.Name;
            Country = new CountryViewModel() { Id = company.Country.Id, CountryName = company.Country.CountryName, FlagUrl = company.Country.FlagUrl };
            City = new CityViewModel() { Id = company.City.Id, CityName = company.City.CityName };
            Employees = company.Employees2Companies.Select(empl =>  new EmployeeViewModel() 
            { 
                Id = empl.Employee.Id, 
                FirstName = empl.Employee.FirstName, 
                SecondName = empl.Employee.SecondName, 
                Country = new CountryViewModel() { Id = empl.Employee.Country.Id, FlagUrl = empl.Employee.Country.FlagUrl } 
            }).ToList();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public CountryViewModel Country { get; set; }

        public CityViewModel City { get; set; }

        public List<EmployeeViewModel> Employees { get; set; }
    }
}
