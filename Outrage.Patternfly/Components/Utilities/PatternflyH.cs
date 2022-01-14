using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Outrage.Patternfly.Components.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outrage.Patternfly.Components.Utilities
{
    public class PatternflyH1: PatternflyH
    {
        public PatternflyH1(): base(1, "pf-m-4xl") { }
    }
    public class PatternflyH2: PatternflyH
    {
        public PatternflyH2(): base(2, "pf-m-3xl") { }
    }
    public class PatternflyH3: PatternflyH
    {
        public PatternflyH3(): base(3, "pf-m-2xl") { }
    }
    public class PatternflyH4: PatternflyH
    {
        public PatternflyH4(): base(4, "pf-m-xl") { }
    }
    public class PatternflyH5: PatternflyH
    {
        public PatternflyH5(): base(5, "pf-m-lg") { }
    }    
    
    public class PatternflyH6: PatternflyH
    {
        public PatternflyH6(): base(6, "pf-m-md") { }
    }

    public class PatternflyH: PatternflyComponentBase
    {
        private readonly int level = 1;
        private readonly string modifier = "";
        [Parameter]
        public string? Modifier { get; set; } = null;

        [Parameter]
        public RenderFragment? ChildContent { get; set; }

        public PatternflyH(int level, string modifier): base()
        {
            this.level = level;
            this.modifier = modifier;
        }
        protected override IEnumerable<string> OnIntroduceClasses()
        {
            return new List<string>(new string[] { "pf-c-title", Modifier ?? modifier, Class });
        }

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            builder.OpenElement(0, $"h{level}");
            builder.AddAttribute(1, "class", String.Join(" ", classes));
            ChildContent?.Invoke(builder);
            builder.CloseElement();

            base.BuildRenderTree(builder);
        }
    }
}
