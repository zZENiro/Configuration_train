using Configuration_train.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Configuration_train.Data.ManyToManyEntities
{
    public class Employees2Companies
    {
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
