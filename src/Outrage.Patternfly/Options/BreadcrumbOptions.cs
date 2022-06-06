using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Outrage.Patternfly.Options
{
    public class BreadcrumbOptions
    {
        internal Regex HrefPattern = new Regex("^(.*?)(?:#.*){0,1}$", RegexOptions.Compiled);
        internal Regex TitlePattern = new Regex("^(?:.*?-){0,1}\\s*(.*)$");

        public void SetHrefPattern(string pattern)
        {
            this.HrefPattern = new Regex(pattern, RegexOptions.Compiled);
        }

        public void SetTitlePattern(string pattern)
        {
            this.TitlePattern = new Regex(pattern, RegexOptions.Compiled);
        }
    }
}
