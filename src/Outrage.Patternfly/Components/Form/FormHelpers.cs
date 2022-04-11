using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outrage.Patternfly.Components.Form
{
    internal static class FormHelpers
    {
        public static Dictionary<string, object> PatternflyAugment(IReadOnlyDictionary<string, object>? initialAdditionalAttributes, string className, string? controlName = null, Action<IDictionary<string, object>>? update = null) {
            var additionalAttributes = new Dictionary<string, object>(initialAdditionalAttributes ?? new Dictionary<string, object>());
            List<string> classes = new List<string>(className.Split(" ", StringSplitOptions.RemoveEmptyEntries));
            if (additionalAttributes.ContainsKey("class"))
            {
                var additionalClasses = new List<string>((additionalAttributes["class"]?.ToString() ?? String.Empty).Split(" ", StringSplitOptions.RemoveEmptyEntries).Reverse());
                foreach (var c in additionalClasses)
                {
                    if (!classes.Contains(c))
                        classes.Insert(0, c);
                }
            }
            additionalAttributes["class"] = String.Join(" ", classes);

            var name = controlName;
            if (additionalAttributes.ContainsKey("name"))
            {
                name = (string)additionalAttributes["name"];
            }
            if (!string.IsNullOrEmpty(name))
                additionalAttributes["name"] = name;

            if (!string.IsNullOrEmpty(controlName))
                additionalAttributes["id"] = controlName;

            if (update != null)
            {
                update(additionalAttributes);
            }

            return additionalAttributes;

        }
    }
}
