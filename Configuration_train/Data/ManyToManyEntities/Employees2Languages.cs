using Configuration_train.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Configuration_train.Data.ManyToManyEntities
{
    public class Employees2Languages
    {
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public int LanguageId { get; set; }
        public Language Language { get; set; }
    }
}
