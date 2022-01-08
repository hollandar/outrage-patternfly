using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace Outrage.Patternfly.Components.Form;

public class PatternflyEditForm : EditForm
{
    [Parameter]
    public bool Horizontal { get; set; } = false;

    protected override void OnParametersSet()
    {
        var classes = "pf-c-form";
        var additionalAttributes = new Dictionary<string, object>(this.AdditionalAttributes ?? new Dictionary<string, object>());
        if (additionalAttributes.ContainsKey("class"))
        {
            classes += " " + additionalAttributes["class"];
        }

        if (Horizontal)
            classes += " pf-m-horizontal";

        additionalAttributes["class"] = classes;
        this.AdditionalAttributes = additionalAttributes;

        base.OnParametersSet();
    }
}
