using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Configuration_train.ModelViews
{
    public class CompanyViewModel 
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public CountryViewModel Country { get; set; }

        public CityViewModel City { get; set; }

        public List<EmployeeViewModel> Employees { get; set; }
    }
}
