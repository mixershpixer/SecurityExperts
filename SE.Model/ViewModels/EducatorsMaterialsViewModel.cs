using SE.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace SE.Model.ViewModels
{
    public class EducatorsMaterialsViewModel
    {
        public string SearchText { get; set; } = null;

        public Enums.Type Type { get; set; } = Enums.Type.Common;

        public Enums.Theme Theme { get; set; }

        public IEnumerable<MaterialViewModel> Materials { get; set; }

        public int Page { get; set; }

        public int TotalCount { get; set; }
    }
}
