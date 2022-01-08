﻿using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outrage.Patternfly.Components.Form;
public class PatternflyInputTextArea : InputTextArea
{
    [CascadingParameter(Name = "FieldName")]
    public string? FieldName { get; set; }

    protected override void OnParametersSet()
    {
        this.AdditionalAttributes = FormHelpers.PatternflyAugment(AdditionalAttributes, "pf-c-form-control", this.FieldName) ?? null;
        base.OnParametersSet();
    }
}
