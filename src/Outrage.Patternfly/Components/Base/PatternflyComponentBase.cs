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
        private Dictionary<string, object>? additionalAttributes = new Dictionary<string, object>();

        [Parameter(CaptureUnmatchedValues = true)]
        public Dictionary<string, object>? AdditionalAttributes { get { return DeriveAdditionalAttributes(); } set { this.additionalAttributes = value; } }

        [Parameter]
        public string? Class { get; set; } = null;

        protected string Classes { get { return DeriveClasses(); } }

        protected virtual string DeriveClasses()
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

            return String.Join(" ", classes);
        }

        public Dictionary<string, object> DeriveAdditionalAttributes() {

            return this.additionalAttributes?.Where(r => r.Key != "class").ToDictionary(r => r.Key, r => r.Value) ?? new Dictionary<string, object>();
        }

        protected virtual IEnumerable<string> OnIntroduceClasses()
        {
            return Enumerable.Empty<string>();
        }
    }
}
