using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace Outrage.Patternfly.Components.Form;

public class PatternflyEditForm : EditForm
{
    [Parameter]
    public bool Horizontal { get; set; } = false;

    protected override void OnParametersSet()
    {
        if (Horizontal)
            this.AdditionalAttributes = FormHelpers.PatternflyAugment(this.AdditionalAttributes, "pf-v5-c-form pf-m-horizontal");
        else
            this.AdditionalAttributes = FormHelpers.PatternflyAugment(this.AdditionalAttributes, "pf-v5-c-form");

        base.OnParametersSet();
    }
}
