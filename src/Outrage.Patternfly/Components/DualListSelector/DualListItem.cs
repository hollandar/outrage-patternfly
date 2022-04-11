using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outrage.Patternfly.Components.DualListSelector
{
    public class DualListItem<TKey>
    {
        TKey key;
        string value;
        int? count;

        public DualListItem(TKey key, string value, int? count = null, bool isSelected = false)
        {
            this.key = key;
            this.value = value;
            this.count = count;
            this.IsSelected = isSelected;
        }

        public bool IsHighlighted { get; set; } = false;
        public bool IsSelected { get; set; }
        public bool HasCount => count.HasValue;
        public int Count => count ?? 0;

        public TKey Key => key;
        public string Value => value;
    }
}
