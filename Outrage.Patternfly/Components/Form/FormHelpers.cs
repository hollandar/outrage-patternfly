using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outrage.Patternfly.Components.Form
{
    internal static class FormHelpers
    {
        public static Dictionary<string, object> PatternflyAugment(IReadOnlyDictionary<string, object>? initialAdditionalAttributes, string className, string? controlName, Action<IDictionary<string, object>> update = null) {
            var classes = className;
            var additionalAttributes = new Dictionary<string, object>(initialAdditionalAttributes ?? new Dictionary<string, object>());
            if (additionalAttributes.ContainsKey("class"))
            {
                classes += " " + additionalAttributes["class"];
            }
            additionalAttributes["class"] = classes;

            var name = controlName;
            if (additionalAttributes.ContainsKey("name"))
            {
                name = (string)additionalAttributes["name"];
            }
            additionalAttributes["name"] = name;
            additionalAttributes["id"] = controlName;

            if (update != null)
            {
                update(additionalAttributes);
            }

            return additionalAttributes;

        }
    }
}
