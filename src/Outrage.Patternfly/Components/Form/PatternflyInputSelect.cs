using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outrage.Patternfly.Components.Form;
public class PatternflyInputSelect<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] TValue> : InputSelect<TValue>
{
    [CascadingParameter(Name = "FieldName")]
    public string? FieldName { get; set; }

    protected override void OnParametersSet()
    {
        this.AdditionalAttributes = FormHelpers.PatternflyAugment(AdditionalAttributes, "pf-v5-c-form-control", this.FieldName) ?? null;
        base.OnParametersSet();
    }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder.OpenElement(901, "span");
        builder.AddAttribute(902, "class", "pf-v5-c-form-control");
            base.BuildRenderTree(builder);
            builder.OpenElement(910, "span");
            builder.AddAttribute(911, "class", "pf-v5-c-form-control__utilities");
                builder.OpenElement(920, "span");
                builder.AddAttribute(921, "class", "pf-v5-c-form-control__toggle-icon");
                    builder.OpenElement(930, "i");
                    builder.AddAttribute(931, "class", "fas fa-caret-down");
                    builder.AddAttribute(931, "aria-hidden", "true");
                    builder.CloseElement();
                builder.CloseElement();
            builder.CloseElement();
        builder.CloseElement();
    }
}
