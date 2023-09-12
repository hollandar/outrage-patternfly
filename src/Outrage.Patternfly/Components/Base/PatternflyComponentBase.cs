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
        public Dictionary<string, object>? CapturedAttributes { get; set; }

        public Dictionary<string, object> AdditionalAttributes { get { return DeriveAdditionalAttributes(this.CapturedAttributes ?? new Dictionary<string, object>()); } }

        [Parameter]
        public string? Class { get; set; } = null;

        protected string Classes { get { return DeriveClasses(); } }

        public void DefineIfUndefined(string key, string value)
        {
            if (this.CapturedAttributes is null) CapturedAttributes = new Dictionary<string, object>();
            if (!this.CapturedAttributes.ContainsKey(key)) this.CapturedAttributes.Add(key, value);
        }

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

        public virtual Dictionary<string, object> DeriveAdditionalAttributes(Dictionary<string, object> additionalAttributes) {

            return additionalAttributes.Where(r => r.Key != "class").ToDictionary(r => r.Key, r => r.Value);
        }

        protected virtual IEnumerable<string> OnIntroduceClasses()
        {
            return Enumerable.Empty<string>();
        }
    }
}
