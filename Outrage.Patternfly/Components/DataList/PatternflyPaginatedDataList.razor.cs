using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;
using Outrage.EventBus;
using Outrage.Patternfly.Components.Base;
using Outrage.Patternfly.Models;
using Outrage.Patternfly.Services;

namespace Outrage.Patternfly.Components.DataList
{
    public partial class PatternflyPaginatedDataList<TItemModel, TItemKey> : PatternflyComponentBase
	{
		[Parameter] public string? StateId { get; set; }
		[Parameter] public bool Compact { get; set; }
		[Parameter] public bool CompactPagination { get; set; }
		[Parameter] public string? AriaLabel { get; set; }
		[Parameter] public int DefaultPageSize { get; set; } = 5;
		[Parameter] public Func<DataPageLoadArgs<TItemKey>, Task<DataPageLoadResult<TItemModel>?>>? OnLoadItems { get; set; }
		[Parameter] public EventCallback<TItemModel> OnItemClicked { get; set; }
		[Parameter] public Func<TItemModel, string?>? ItemAriaLabel { get; set; }

		[Parameter] public RenderFragment? NoItemsMessage { get; set; }
		[Parameter] public RenderFragment? ToolbarItems { get; set; }
		[Parameter] public RenderFragment<TItemModel>? ItemTemplate { get; set; }

		[Inject] ILogger<PatternflyPaginatedDataList<TItemModel, TItemKey>>? logger { get; set; }
		[Inject] IClientEventBus? eventBus { get; set; }
		[Inject] DataPageModelFactory? dataPageModelFactory { get; set; }

		private DataPageModel<TItemModel>? pageModel;

		protected override async Task OnInitializedAsync()
		{
			await base.OnInitializedAsync();
			if (pageModel == null || pageModel.StateId != StateId)
			{
				pageModel = await dataPageModelFactory!.Create<TItemModel>(StateId, DefaultPageSize);
			}
			if (pageModel != null)
			{
				await Refresh();
			}
		}

		public async Task Refresh(bool reset = false)
		{
			if (pageModel != null && OnLoadItems != null)
			{
				var result = await OnLoadItems(new DataPageLoadArgs<TItemKey> { Page = reset ? 0 : pageModel.Page, PageSize = pageModel.PageSize });
				if (result != null)
				{
					await pageModel.Update(result);
					this.StateHasChanged();
				}
			}
		}

		private async Task SelectPage(int page)
		{
			if (pageModel != null && OnLoadItems != null)
			{
				var result = await OnLoadItems(new DataPageLoadArgs<TItemKey> { Page = page, PageSize = pageModel.PageSize });
				if (result != null)
				{
					await pageModel.Update(result);
					this.StateHasChanged();
				}
			}
		}

		private async Task SelectPageSize(int pageSize)
		{
			if (pageModel != null && OnLoadItems != null)
			{
				var result = await OnLoadItems(new DataPageLoadArgs<TItemKey> { Page = 0, PageSize = pageSize });
				if (result != null)
				{
					await pageModel.Update(result);
					this.StateHasChanged();
				}
			}
		}
	}
}
