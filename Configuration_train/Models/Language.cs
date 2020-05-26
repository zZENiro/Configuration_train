using Configuration_train.Data;
using Configuration_train.Data.ManyToManyEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Configuration_train.Models
{
    public class Language
    {
        public int Id { get; set; }

        public string LanguageName { get; set; }

        public List<Employees2Languages> Employees2Languages { get; set; }
    }
}
