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

            InitializeCollecton();
        }

        public List<EmployeeViewModel> Collection { get; set; }

        private void InitializeCollecton()
        {
            var src = _context.Employees
                                 .Include(prop => prop.City)
                                 .Include(prop => prop.Company)
                                 .Include(prop => prop.Country)
                                 .Include(prop => prop.Employees2Companies)
                                 .Include(prop => prop.Employees2Languages)
                                 .ToList();

            
        }
    }
}
