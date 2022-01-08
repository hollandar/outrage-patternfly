using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outrage.Patternfly.Helpers
{
    public class HtmlId
    {
        string id;
        public HtmlId()
        {
            id = $"_{Guid.NewGuid().ToString().Replace("-", String.Empty)}";
        }

        public HtmlId(string id)
        {
            this.id = id;
        }

        public string Value
        {
            get { return id; }
        }

        public override string ToString()
        {
            return this.Value;
        }

        public override int GetHashCode()
        {
            return this.Value.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            var id = obj as HtmlId;
            if (id != null && id.Value == this.Value)
                return true;

            return false;
        }

        public static string Create()
        {
            return new HtmlId().Value;
        }

        public string With(string with)
        {
            return $"{this.Value}_{with}";
        }
    }
}
