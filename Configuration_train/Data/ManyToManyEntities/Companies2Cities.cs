using Configuration_train.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Configuration_train.Data.ManyToManyEntities
{
    public class Companies2Cities
    {
        public int CompanyId { get; set; }
        public Company Company { get; set; }

        public int CityId { get; set; }
        public City City { get; set; }
    }
}
