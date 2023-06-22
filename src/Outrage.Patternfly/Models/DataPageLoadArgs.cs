using Outrage.Patternfly.Components.Table;

namespace Outrage.Patternfly.Models
{
    public class DataPageLoadArgs<TItemKey>
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
        public int StartRecord
        {
            get => Page * PageSize;
            set => Page = value / PageSize;
        }
        public TItemKey? SelectedItemKey { get; set; }

        public string? SortBy { get; set; }
        public SortOrder SortOrder { get; set; }
    }
}
