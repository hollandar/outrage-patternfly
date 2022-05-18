using Blazored.LocalStorage;
using Microsoft.Extensions.DependencyInjection;
using Outrage.Patternfly.Services;

namespace Outrage.Patternfly
{
    public static class StartupExtensions
    {
        public static void AddPatternflyToaster(this IServiceCollection services)
        {
            services.AddSingleton<ToasterService>();
        }

        public static void AddPatternflyPagedModelFactory(this IServiceCollection services)
        {
            services.AddScoped<DataPageModelFactory>();
            services.AddBlazoredLocalStorage();
        }
    }
}
