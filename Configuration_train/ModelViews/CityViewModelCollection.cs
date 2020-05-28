using Configuration_train.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Configuration_train.ModelViews
{
    public class CityViewModelCollection
    {
        EmployeesDbContext _context;

        public List<CityViewModel> Collection { get; set; }
        
        public CityViewModelCollection(EmployeesDbContext context)
        {
            _context = context;
            Collection = InitializeCollecton();
        }

        private List<CityViewModel> InitializeCollecton() =>
                         _context.Cities
                                 .Include(prop => prop.Companies)
                                 .Include(prop => prop.Employees)
                                 .ToList()
                                 .Select(empl => new CityViewModel(empl)).ToList();


    }
}
