using Configuration_train.Data;
using Configuration_train.Data.ManyToManyEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Configuration_train.Models
{
    public class Company
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Country Country { get; set; }

        public City City { get; set; }

        public List<Employee> Employees { get; set; }

        // Employeers History 
        public List<Employees2Companies> Employees2Companies { get; set; }
    }
}
