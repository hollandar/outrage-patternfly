using Blazored.LocalStorage;
using Outrage.Patternfly.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Outrage.Patternfly.Services
{
    public class BreadcrumbService
    {
        private readonly ILocalStorageService localStorage;
        private readonly BreadcrumbOptions options;
        public event EventHandler BreadcrumbsChanged = default!;

        public BreadcrumbService(ILocalStorageService localStorage, BreadcrumbOptions options)
        {
            this.localStorage = localStorage;
            this.options = options;
        }

        public Regex TitlePattern { get { return this.options.TitlePattern; } }

        public async Task<IEnumerable<Breadcrumb>> GetAsync()
        {
            var breadcrumbs = (await this.localStorage.GetItemAsync<List<Breadcrumb>?>("breadcrumbs.session")) ?? new List<Breadcrumb>();

            return breadcrumbs;
        }

        internal string RegexMatches(Regex regex, string? input)
        {
            if (input != null)
            {
                var match = regex.Match(input);
                if (match.Success)
                {
                    var builder = new StringBuilder();
                    for (var i = 1; i < match.Groups.Count; i++)
                    {
                        builder.Append(match.Groups[i].ValueSpan);
                    }

                    return builder.ToString();
                }
            }

            return String.Empty;
        }

        public async Task<IEnumerable<Breadcrumb>> VisitAsync(string href, string name)
        {
            var breadcrumbs = (await this.localStorage.GetItemAsync<List<Breadcrumb>?>("breadcrumbs.session")) ?? new List<Breadcrumb>();

            var index = breadcrumbs.FindIndex((breadcrumb) => RegexMatches(options.HrefPattern, breadcrumb.Href) == RegexMatches(options.HrefPattern,href));

            if (index > -1)
            {
                breadcrumbs.RemoveRange(index, breadcrumbs.Count - index);
            }

            breadcrumbs.Add(new Breadcrumb(href, name));

            await this.localStorage.SetItemAsync("breadcrumbs.session", breadcrumbs);

            this.BreadcrumbsChanged.Invoke(this, EventArgs.Empty);

            return breadcrumbs;

        }

        public async Task ClearAsync()
        {
            this.BreadcrumbsChanged.Invoke(this, EventArgs.Empty);

            await this.localStorage.SetItemAsync<List<Breadcrumb>?>("breadcrumbs.session", null);
        }
    }

    public class Breadcrumb
    {
        public Breadcrumb(string href, string name)
        {
            this.Href = href;
            this.Name = name;
        }

        public string Href { get; set; }
        public string Name { get; set; }
    }
}
