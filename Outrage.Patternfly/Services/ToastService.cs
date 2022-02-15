using Outrage.EventBus;
using Outrage.Patternfly.Components.Alert;
using Outrage.Patternfly.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outrage.Patternfly.Services
{
    public class ToastService
    {
        private readonly IClientEventBus clientEventBus;
        public ToastService(IClientEventBus clientEventBus)
        {
            this.clientEventBus = clientEventBus;
        }

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
