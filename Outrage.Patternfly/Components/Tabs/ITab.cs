using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outrage.Patternfly.Components.Tabs
{
    public interface ITab
    {
        string TabId { get; }
        string PanelCssClass { get; }
        RenderFragment ChildContent { get; }

        Task ActivateTab();
    }
}
