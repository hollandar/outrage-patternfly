using Microsoft.AspNetCore.Components;

namespace Outrage.Patternfly.Components.Tabs
{
    public interface ITab
    {
        string TabId { get; }
        string? PanelCssClass { get; }
        RenderFragment? ChildContent { get; }

        Task ActivateTab();
    }
}
