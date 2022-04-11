namespace Outrage.Patternfly.Models
{
    public class DataPageLoadResult<TItemModel>
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
        public int TotalRecords { get; set; }
        public IEnumerable<TItemModel>? Items { get; set; }
    }
}
