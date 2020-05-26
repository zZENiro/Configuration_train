using Configuration_train.Data;
using Configuration_train.Data.ManyToManyEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Configuration_train.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public Country Country { get; set; }

        public Company Company { get; set; }

        public City City { get; set; }

        [NotMapped]
        public List<Company> CompaniesHistory { get => Employees2Companies.Select(conn => conn.Company).ToList(); }
        public List<Employees2Companies> Employees2Companies { get; set; }

        [NotMapped]
        public List<Language> Languages { get => Employees2Languages.Select(conn => conn.Language).ToList(); }
        public List<Employees2Languages> Employees2Languages { get; set; }
    }
}
