using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outrage.Patternfly.Components.Form;
public class PatternflyInputText : InputText
{
    [CascadingParameter(Name = "FieldName")]
    public string? FieldName { get; set; }

    protected override void OnParametersSet()
    {
        var classes = "pf-c-form-control";
        var additionalAttributes = new Dictionary<string, object>(this.AdditionalAttributes ?? new Dictionary<string, object>());
        if (additionalAttributes.ContainsKey("class"))
        {
            classes += " " + additionalAttributes["class"];
        }
        additionalAttributes["class"] = classes;

        additionalAttributes["type"] = "text";

        var name = this.FieldName;
        if (additionalAttributes.ContainsKey("name"))
        {
            name = (string)additionalAttributes["name"];
        }
        additionalAttributes["name"] = name;
        additionalAttributes["id"] = this.FieldName;


        this.AdditionalAttributes = additionalAttributes;
        base.OnParametersSet();
    }
}
