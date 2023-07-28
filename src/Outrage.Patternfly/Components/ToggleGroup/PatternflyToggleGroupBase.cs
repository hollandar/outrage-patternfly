using Microsoft.AspNetCore.Components;
using Outrage.Patternfly.Components.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outrage.Patternfly.Components.ToggleGroup
{
    public abstract class PatternflyToggleGroupBase<TValueType> : PatternflyComponentBase
    {
        List<PatternflyToggleGroupItem<TValueType>> toggleGroupItems = new();

        public PatternflyToggleGroupBase(): base()
        {
        }

        public void AddToggleGroupItem(PatternflyToggleGroupItem<TValueType> group)
        {
            this.toggleGroupItems.Add(group);
        }

        public abstract Task SetValue(TValueType? value);
        public abstract bool Contains(TValueType value);
    }
}
