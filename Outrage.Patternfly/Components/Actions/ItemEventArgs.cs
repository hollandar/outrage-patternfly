using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outrage.Patternfly.Components.Actions
{
    public class ItemEventArgs<TItem>: EventArgs
    {
        public MouseEventArgs MouseEventArgs { get; init; }
        public TItem Value { get; init; }

        public ItemEventArgs(MouseEventArgs mouseArgs, TItem item)
        {
            this.MouseEventArgs = mouseArgs;
            this.Value = item;
        }
    }
}
