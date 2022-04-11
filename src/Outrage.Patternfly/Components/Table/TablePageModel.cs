using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Outrage.Patternfly.Components.Table
{
    public class TablePageModel<T>
    {
        List<TableRowWrapper<T>> items = new List<TableRowWrapper<T>>();

        public TablePageModel(int total = 0, IEnumerable<T>? items = null)
        {
            this.Total = total;
            this.items = new List<TableRowWrapper<T>>(ToWrappers(items));
        }

        public int Total { get; private set; }
        public IEnumerable<TableRowWrapper<T>> Items => this.items;

        public void UpdateList(int total, IEnumerable<T> items)
        {
            this.Total = total;
            this.items.Clear();
            this.items.AddRange(ToWrappers(items));
        }

        private IEnumerable<TableRowWrapper<T>> ToWrappers(IEnumerable<T>? items)
        {
            if (items == null) return Enumerable.Empty<TableRowWrapper<T>>();
            return items.Select(i => new TableRowWrapper<T>(i));
        }
    }

    public class PageSwitchArgs<TItemKey>
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
        public TItemKey? Id { get; set; }
    }
}
