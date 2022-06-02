using Blazored.LocalStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outrage.Patternfly.Services
{
    public class BreadcrumbService
    {
        private readonly ILocalStorageService localStorage;

        public BreadcrumbService(ILocalStorageService localStorage)
        {
            this.localStorage = localStorage;
        }

        public async Task <IEnumerable<Breadcrumb>> GetAsync()
        {
            var breadcrumbs = (await this.localStorage.GetItemAsync<List<Breadcrumb>?>("breadcrumbs.session")) ?? new List<Breadcrumb>();

            return breadcrumbs;
        }

        public async Task<IEnumerable<Breadcrumb>> VisitAsync(string href, string name)
        {
            var breadcrumbs = (await this.localStorage.GetItemAsync<List<Breadcrumb>?>("breadcrumbs.session")) ?? new List<Breadcrumb>();

            var index = breadcrumbs.FindIndex((breadcrumb) => breadcrumb.Href == href);

            if (index > -1)
            {
                breadcrumbs = breadcrumbs.Take(index).ToList();
            }

            breadcrumbs.Add(new Breadcrumb(href, name));

            await this.localStorage.SetItemAsync("breadcrumbs.session", breadcrumbs);

            return breadcrumbs;

        }

        public async Task ClearAsync()
        {
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
