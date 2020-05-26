using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Configuration_train.ModelViews
{
    public class CountryViewModel 
    {
        public int Id { get; set; }

        public string CountryName { get; set; }

        public string FlagUrl { get; set; }

        public List<EmployeeViewModel> Employees { get; set; }

        public List<CompanyViewModel> Companies { get; set; }
    }
}
