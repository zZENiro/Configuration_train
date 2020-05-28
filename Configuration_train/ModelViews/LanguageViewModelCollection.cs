using Configuration_train.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Configuration_train.ModelViews
{
    public class LanguageViewModelCollection
    {
        EmployeesDbContext _context;

        public List<LanguageViewModel> Collection { get; set; }

        public LanguageViewModelCollection(EmployeesDbContext context)
        {
            _context = context;
            Collection = InitializeCollection();
        }

        private List<LanguageViewModel> InitializeCollection() =>
            _context.Languages.ToList().Select(l => new LanguageViewModel(l)).ToList();
    }
}
