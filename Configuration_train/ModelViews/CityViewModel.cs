using Configuration_train.Data;
using Configuration_train.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Configuration_train.ModelViews
{
    public class CityViewModel 
    {
        public CityViewModel()
        { }

        public CityViewModel(City city)
        {
            Id = city.Id;
            CityName = city.CityName;

            Companies = city.Companies.Select(comp => new CompanyViewModel() 
            { Id = comp.Id, Name = comp.Name }).ToList();

            Employees = city.Employees.Select(empl => new EmployeeViewModel() 
            { Id = empl.Id, FirstName = empl.FirstName, SecondName = empl.SecondName }).ToList();
        }

        public static async Task<CityViewModel> CreateViewModelAsync(EmployeesDbContext context, int id) =>
            new CityViewModel(await context.Cities.FirstAsync(c => c.Id == id));

        public int Id { get; set; }

        public string CityName { get; set; }

        public List<CompanyViewModel> Companies { get; set; }

        public List<EmployeeViewModel> Employees { get; set; }
    }
}
