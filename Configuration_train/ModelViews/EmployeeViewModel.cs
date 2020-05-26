using Configuration_train.Models;
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
            
        }

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
