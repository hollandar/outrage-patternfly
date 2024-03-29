﻿using Outrage.EventBus;
using Outrage.EventBus.Predefined;
using Outrage.Patternfly.Components.Alert;
using Outrage.Patternfly.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outrage.Patternfly.Services
{
    public class ToasterService
    {
        private readonly IEventAggregator clientEventBus;

        public ToasterService(IServiceProvider serviceProvider)
        {
            IEventAggregator? eventBus = (IEventAggregator?) serviceProvider.GetService(typeof(IRootEventBus));
            if (eventBus == null)
            {
                eventBus = (IEventAggregator?)serviceProvider.GetService(typeof(IClientEventBus));
            }
            if (eventBus == null)
            {
                eventBus = new RootEventBus(serviceProvider);
            }
            this.clientEventBus = eventBus;
        }

        public IEventAggregator Bus => clientEventBus;

        public async Task Publish(ToastMessage toastMessage)
        {
            await this.clientEventBus.PublishAsync<ToastMessage>(toastMessage);
        }

        public async Task Publish(string message, AlertColor severity = AlertColor.Info)
        {
            await this.Publish(new ToastMessage(message, severity));
        }

        public async Task Publish(Exception e)
        {
            await this.Publish(e.Message, AlertColor.Danger);
        }
    }
}
