using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outrage.Patternfly.Components.Form
{
    public class PatternflyCheckbox: InputCheckbox
    {
        [Parameter]
        public string Label { get; set; }

        [CascadingParameter(Name = "FieldName")]
        public string? FieldName { get; set; }

        protected override void OnParametersSet()
        {
            AdditionalAttributes = FormHelpers.PatternflyAugment(AdditionalAttributes, "pf-c-check__input", this.FieldName);
            base.OnParametersSet();
        }
        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            builder.OpenElement(901, "div");
            builder.AddAttribute(902, "class", "pf-c-check");
            base.BuildRenderTree(builder);
            if (!String.IsNullOrEmpty(Label))
            {
                builder.OpenElement(903, "label");
                builder.AddAttribute(904, "class", "pf-c-check__label");
                builder.AddAttribute(905, "for", this.FieldName);
                builder.AddContent(906, this.Label);
                builder.CloseElement();
            }
            builder.CloseElement();
        }
    }
}
