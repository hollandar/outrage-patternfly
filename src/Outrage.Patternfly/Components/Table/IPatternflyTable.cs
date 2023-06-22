using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outrage.Patternfly.Components.Table
{
    public interface IPatternflyTable
    {
        public string? SortBy { get; }
        public SortOrder SortOrder { get; }

        public Task SelectSortAsync(string sortBy, SortOrder sortOrder);
    }
}
