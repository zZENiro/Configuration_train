using Configuration_train.Data;
using Configuration_train.Data.ManyToManyEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace Configuration_train.Models
{
    public class Country
    {
        public int Id { get; set; }

        public string CountryName { get; set; }

        public string FlagUrl { get; set; }

        public List<Employee> Employees { get; set; }

        public List<Company> Companies { get; set; }
    }
}
