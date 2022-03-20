using Blazored.LocalStorage;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Outrage.Patternfly.Models;

namespace Outrage.Patternfly.Services
{
    /// <summary>
    /// Creates and initialises DataPageModel instances.
    /// Initialisation involves retrieving pagination state such as page and page size values from local storage.
    /// </summary>
    public class DataPageModelFactory
    {
        private readonly ILoggerFactory loggerFactory;
        private readonly ILocalStorageService? localStorageService;

        public DataPageModelFactory(
            ILoggerFactory loggerFactory,
            IServiceProvider serviceProvider)
        {
            this.loggerFactory = loggerFactory;
            this.localStorageService = serviceProvider.GetService<ILocalStorageService>();
        }

        public async Task<DataPageModel<TItemModel>> Create<TItemModel>(string? stateId = null, int defaultPageSize = 5)
        {
            var model = new DataPageModel<TItemModel>(loggerFactory.CreateLogger<DataPageModel<TItemModel>>(), localStorageService, stateId, defaultPageSize);
            await model.Initialize();
            return model;
        }
    }
}
