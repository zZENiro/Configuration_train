using Configuration_train.Data.ManyToManyEntities;
using System.Collections.Generic;

namespace Configuration_train.Models
{
    public class City
    {
        public int Id { get; set; }
        
        public string CityName { get; set; }

        public List<Company> Companies { get; set; }

        public List<Employee> Employees { get; set; }
    }
}