using Blazored.LocalStorage;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Outrage.Patternfly.Options;
using Outrage.Patternfly.Services;

namespace Outrage.Patternfly
{
    public static class StartupExtensions
    {
        public static void AddPatternflyToaster(this IServiceCollection services)
        {
            services.TryAddSingleton<ToasterService>();
        }

        public static void AddPatternflyPagedModelFactory(this IServiceCollection services)
        {
            services.TryAddScoped<DataPageModelFactory>();
            services.AddBlazoredLocalStorage();
        }

        public static void AddPatternflyBreadcrumb(this IServiceCollection services, Action<BreadcrumbOptions>? optionsAction = null)
        {
            var breadcrumbOptions = new BreadcrumbOptions();
            if (optionsAction != null)
                optionsAction(breadcrumbOptions);
            services.TryAddSingleton<BreadcrumbOptions>(breadcrumbOptions);
            services.TryAddScoped<BreadcrumbService>();
            services.AddBlazoredLocalStorage();
        }
    }
}
