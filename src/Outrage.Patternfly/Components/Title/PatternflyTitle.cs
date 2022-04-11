using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outrage.Patternfly.Components.Title
{
    public enum TitleSize { xl4, xl3, xl2, xl, lg, md, unset };
    public class PatternflyTitle: Patternfly.Components.Base.PatternflyComponentBase
    {
        [Parameter] public int HeadingLevel { get; set; } = 1;
        [Parameter] public TitleSize Size { get; set; } = TitleSize.unset;

        [Parameter] public RenderFragment? ChildContent { get; set; }

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            builder.OpenElement(0, $"h{HeadingLevel}");
            builder.AddAttribute(1, "class", Classes);
            builder.AddMultipleAttributes(2, AdditionalAttributes);
            ChildContent?.Invoke(builder);
            builder.CloseElement();

            base.BuildRenderTree(builder);
        }

        protected override IEnumerable<string> OnIntroduceClasses()
        {
            var classes = new HashSet<string>(new string[] { "pf-c-title" });
            classes.Add(Size switch
            {
                TitleSize.xl4 => "pf-m-4xl",
                TitleSize.xl3 => "pf-m-3xl",
                TitleSize.xl2 => "pf-m-2xl",
                TitleSize.xl => "pf-m-xl",
                TitleSize.lg => "pf-m-lg",
                TitleSize.md => "pf-m-md",
                TitleSize.unset => HeadingLevel switch
                {
                    1 => "pf-m-4xl",
                    2 => "pf-m-3xl",
                    3 => "pf-m-2xl",
                    4 => "pf-m-xl",
                    5 => "pf-m-lg",
                    6 => "pf-m-md",
                    _ => throw new NotSupportedException()
                },
                _ => throw new NotSupportedException()
            });

            return classes;
        }
    }
}
