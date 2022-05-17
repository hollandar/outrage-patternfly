using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outrage.Patternfly.Components.Page
{
    public class PatternflyOnPage : ComponentBase, IDisposable
    {
        [CascadingParameter(Name ="PatternflyParentPage")] public PatternflyPage? ParentPage { get; set; } 
        [Parameter] public RenderFragment? ChildContent { get; set; }

        public event Action OnChange = default!;
        protected override void OnInitialized()
        {
            if (ParentPage != null)
            {
                ParentPage.SetOnPage(this);
            }
            else
            {
                throw new Exception("PatternflyOnPage must be used within a PatternflyPage context.");
            }
            Update();
            base.OnInitialized();
        }

        public void Update()
        {
            OnChange?.Invoke();
        }

        protected override bool ShouldRender()
        {
            var shouldRender = base.ShouldRender();
            if (shouldRender)
            {
                this.Update();
            }

            return shouldRender;
        }


        public void Dispose()
        {
            if (ParentPage?.IsSetOnPage(this) ?? false)
            {
                ParentPage?.SetOnPage(null);
            }
        }

    }
}
