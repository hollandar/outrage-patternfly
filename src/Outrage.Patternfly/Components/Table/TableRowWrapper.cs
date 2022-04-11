using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Outrage.Patternfly.Components.Table
{
    public class TableRowWrapper<T>
    {
        public TableRowWrapper  (T item)
        {
            this.Item = item;
            this.IsSelected = false;
        }

        public T Item { get; private set; }
        public bool IsSelected { get; set; }
    }
}
