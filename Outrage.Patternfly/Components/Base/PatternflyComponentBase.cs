using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outrage.Patternfly.Components.Base
{
    public class PatternflyComponentBase: ComponentBase
    {
        [Parameter(CaptureUnmatchedValues = true)]
        public Dictionary<string, object>? AdditionalAttributes { get; set; } = new Dictionary<string, object>();

        [Parameter]
        public string? Class { get; set; } = null;

        protected string classes = "";
        protected string Classes { get { return classes; } }
        protected override void OnParametersSet()
        {
            AdjustClasses();
            base.OnParametersSet();
        }

        protected virtual void AdjustClasses()
        {
            var classes = new HashSet<string>();

            if (AdditionalAttributes?.ContainsKey("class") ?? false)
            {
                var elementClass = AdditionalAttributes["class"];
                var elementClasses = (elementClass?.ToString() ?? "").Split(" ", StringSplitOptions.RemoveEmptyEntries);
                foreach (var @class in elementClasses) classes.Add(@class);
            }

            if (Class != null)
            {
                var elementClasses = (Class?.ToString() ?? "").Split(" ", StringSplitOptions.RemoveEmptyEntries);
                foreach (var @class in elementClasses) classes.Add(@class);
            }

            foreach (var @class in OnIntroduceClasses()) 
                classes.Add(@class);

            AdditionalAttributes?.Remove("class");

            this.classes = String.Join(" ", classes);
        }

        protected virtual IEnumerable<string> OnIntroduceClasses()
        {
            return Enumerable.Empty<string>();
        }
    }
}
