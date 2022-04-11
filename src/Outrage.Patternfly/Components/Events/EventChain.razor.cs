using Microsoft.AspNetCore.Components;
using Outrage.EventBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outrage.Patternfly.Components.Events
{
    public partial class EventChain
    {
        class ChainEventAggregator : EventAggregator
        {
            public ChainEventAggregator(IServiceProvider serviceProvider) : base(serviceProvider)
            {
                this.AddDefaultLogSubscriber();
                this.AddDefaultExceptionSubscriber();
            }
        }

        ChainEventAggregator? eventAggregator = null;

        ISubscriber? subscriber;

        [Parameter] public RenderFragment? ChildContent { get; set; }

        [CascadingParameter] public EventChain? ParentChain { get; set; }

        [Inject] IServiceProvider? ServiceProvider { get; set; }

        [Parameter] public EventCallback<MessageEventArgs> OnMessage { get; set; }

        protected override Task OnInitializedAsync()
        {
            this.eventAggregator = new ChainEventAggregator(this.ServiceProvider!);

            this.subscriber = this.eventAggregator.Subscribe(this.MessageSubscriberAsync);
            return base.OnInitializedAsync();
        }

        public async Task MessageSubscriberAsync(EventContext context, IMessage message)
        {
            if (this.ParentChain != null)
                await this.ParentChain.Publish(message);

            await this.InvokeAsync(async () =>
            {
                await this.OnMessage.InvokeAsync(new MessageEventArgs(context, message));
            });
        }

        public async Task Publish(IMessage message)
        {
            await this.eventAggregator!.PublishAsync(message);
        }
    }
}
