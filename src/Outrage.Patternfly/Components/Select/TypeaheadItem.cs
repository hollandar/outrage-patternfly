using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outrage.Patternfly.Components.Select
{
    public class TypeaheadItem<TItem>
    {
        public TypeaheadItem(TItem item)
        {
            this.Item = item;
        }

        public TItem Item { get; set; }
        public bool Selected { get; set; } = false;

        public override string ToString()
        {
            return Item?.ToString() ?? string.Empty;
        }
    }
}
