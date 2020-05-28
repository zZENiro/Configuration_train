using Configuration_train.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Configuration_train.ModelViews
{
    public class CountryViewModelCollection
    {
        EmployeesDbContext _context;

        public List<CountryViewModel> Collection { get; set; }

        public CountryViewModelCollection(EmployeesDbContext context)
        {
            _context = context;
            Collection = InitializeCollection();
        }

        private List<CountryViewModel> InitializeCollection() =>
            _context.Countries
                    .Include(prop => prop.Companies)
                    .Include(prop => prop.Employees)
                    .ToList().Select(c => new CountryViewModel(c)).ToList();
    }
}
