using Configuration_train.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Configuration_train.ModelViews
{
    public class CountryViewModel 
    {
        public CountryViewModel()
        { }

        public CountryViewModel(Country country)
        {
            Id = country.Id;
            CountryName = country.CountryName;
            FlagUrl = country.FlagUrl;

            Employees = country.Employees.Select(e =>
            new EmployeeViewModel()
            {
                Id = e.Id,
                FirstName = e.FirstName,
                SecondName = e.SecondName,
                Country = new CountryViewModel() { Id = e.Country.Id, FlagUrl = e.Country.FlagUrl },
                Company = new CompanyViewModel() { Id = e.Company.Id, Name = e.Company.Name }
            }).ToList();

            Companies = country.Companies.Select(c => new CompanyViewModel()
            {
                 Id = c.Id,
                 Name = c.Name,
                 City = new CityViewModel() { Id = c.City.Id, CityName = c.City.CityName },
                 Country = new CountryViewModel() { Id = c.Country.Id, CountryName = c.Country.CountryName, FlagUrl = c.Country.FlagUrl }
            }).ToList();
        }

        public int Id { get; set; }

        public string CountryName { get; set; }

        public string FlagUrl { get; set; }

        public List<EmployeeViewModel> Employees { get; set; }

        public List<CompanyViewModel> Companies { get; set; }
    }
}
