using Configuration_train.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Configuration_train.ModelViews
{
    public class CompanyViewModelCollection
    {
        EmployeesDbContext _context;

        public List<CompanyViewModel> Collection { get; set; }

        public CompanyViewModelCollection(EmployeesDbContext context)
        {
            _context = context;
            Collection = InitializeCollection();
        }

        private List<CompanyViewModel> InitializeCollection() =>
            _context.Companies
                    .Include(prop => prop.City)
                    .Include(prop => prop.Country)
                    .Include(prop => prop.Employees)
                    .ToList().Select(c => new CompanyViewModel(c)).ToList();
    }
}
