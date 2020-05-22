using SE.Common;
using System;
using System.Collections.Generic;
using System.Text;
using static SE.Common.Enums;
using Type = SE.Common.Enums.Type;

namespace SE.Model.ViewModels
{
    public class MaterialsCollectionViewModel
    {
        public string SearchText { get; set; } = null;

        public Type Type { get; set; } = Type.Common;

        public Theme Theme { get; set; }

        public string ThemeString { get; set; }

        public SortType SortType { get; set; }

        public MaterialStatus MaterialStatus { get; set; }

        public IEnumerable<MaterialViewModel> Materials { get; set; }

        public int Page { get; set; }

        public int TotalCount { get; set; }
    }
}
