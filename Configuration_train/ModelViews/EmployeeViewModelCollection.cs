using Configuration_train.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Configuration_train.Models;

namespace Configuration_train.ModelViews
{
    public class EmployeeViewModelCollection
    {
        EmployeesDbContext _context;

        public EmployeeViewModelCollection(EmployeesDbContext context)
        {
            _context = context;
            Collection = InitializeCollecton();
        }

        public List<EmployeeViewModel> Collection { get; set; }

        private List<EmployeeViewModel> InitializeCollecton() => 
                         _context.Employees
                                 .Include(prop => prop.City)
                                 .Include(prop => prop.Company)
                                 .Include(prop => prop.Country)
                                 .Include(prop => prop.Employees2Companies)
                                 .Include(prop => prop.Employees2Languages)
                                 .ToList()
                                 .Select(empl => new EmployeeViewModel()
                                 {
                                     Id         = empl.Id,
                                     FirstName  = empl.FirstName,
                                     SecondName = empl.SecondName,
                                     City       = new CityViewModel()       { Id = empl.City.Id, CityName = empl.City.CityName },
                                     Company    = new CompanyViewModel()    { Id = empl.Company.Id, Name = empl.Company.Name },
                                     Country    = new CountryViewModel()    { Id = empl.Country.Id, CountryName = empl.Country.CountryName, FlagUrl = empl.Country.FlagUrl }
                                 }).ToList();
    }
}
