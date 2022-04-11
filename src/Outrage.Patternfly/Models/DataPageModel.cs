using Blazored.LocalStorage;
using Microsoft.Extensions.Logging;

namespace Outrage.Patternfly.Models
{
    /// <summary>
    /// Represents a page of data for display.
    /// If StateId is specified, this maintains pagination state such as page number, page size and the actual data items.
    /// Changes to pagination state are written through to browser local storage.
    /// </summary>
    /// <typeparam name="TItemModel"></typeparam>
    public class DataPageModel<TItemModel>
    {
        /// <summary>
        /// Unique identifier used as a key for storing the pagination state in browser local storage.
        /// </summary>
        public string? StateId { get;  }

        /// <summary>
        /// Current page index.
        /// </summary>
        public int Page { get; private set; }

        /// <summary>
        /// Starting record index for the page.
        /// </summary>
        public int StartRecord
        {
            get => Page * PageSize;
            private set => Page = value / PageSize;
        }

        /// <summary>
        /// Page size.
        /// </summary>
        public int PageSize { get; private set; }

        /// <summary>
        /// Total records in the full data set.
        /// </summary>
        public int TotalRecords { get; private set; }

        /// <summary>
        /// Page data items wrapped in a DataItemWrapperModel.
        /// </summary>
        public IEnumerable<DataItemWrapperModel<TItemModel>> Items => this.items;

        /// <summary>
        /// Returns true if the model has been loaded with data.
        /// </summary>
        public bool IsLoaded { get; private set; }

        private readonly ILogger<DataPageModel<TItemModel>> logger;
        private readonly ILocalStorageService? localStorageService;
        private int defaultPageSize;

        private List<DataItemWrapperModel<TItemModel>> items = new List<DataItemWrapperModel<TItemModel>>();

        internal DataPageModel(ILogger<DataPageModel<TItemModel>> logger, ILocalStorageService? localStorageService, string? stateId, int defaultPageSize)
        {
            this.logger = logger;
            this.localStorageService = localStorageService;
            this.defaultPageSize = defaultPageSize;
            this.PageSize = defaultPageSize;
            StateId = stateId;
        }

        internal async Task Initialize()
        {
            if (localStorageService != null && !string.IsNullOrEmpty(StateId))
            {
                try
                {
                    this.Page = await localStorageService.GetItemAsync<int>($"{StateId}.page");
                    this.PageSize = await localStorageService.GetItemAsync<int>($"{StateId}.pageSize");
                    if (this.PageSize < 1)
                    {
                        this.PageSize = defaultPageSize;
                    }
                }
                catch (Exception e)
                {
                    logger.LogWarning(e, $"Unable to initialise data page model [{StateId}].");
                }
            }
        }

        public async Task Update(DataPageLoadResult<TItemModel> result)
        {
            this.Page = result.Page;
            this.PageSize = result.PageSize > 0 ? result.PageSize : defaultPageSize;
            this.TotalRecords = result.TotalRecords;
            this.items.Clear();
            if (result.Items != null)
            {
                this.items.AddRange(ToWrappers(result.Items));
            }
            this.IsLoaded = true;

            if (localStorageService != null && !string.IsNullOrEmpty(StateId))
            {
                try
                {
                    await localStorageService.SetItemAsync<int>($"{StateId}.page", this.Page);
                    await localStorageService.SetItemAsync<int>($"{StateId}.pageSize", this.PageSize);
                }
                catch (Exception e)
                {
                    logger.LogWarning(e, $"Unable to update data page model [{StateId}].");
                }
            }
        }

        protected IEnumerable<DataItemWrapperModel<TItemModel>> ToWrappers(IEnumerable<TItemModel>? items)
        {
            if (items == null) return Enumerable.Empty<DataItemWrapperModel<TItemModel>>();
            return items.Select(i => new DataItemWrapperModel<TItemModel>(i));
        }
    }
}
