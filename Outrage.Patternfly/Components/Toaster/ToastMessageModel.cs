using Outrage.Patternfly.Messages;

namespace Outrage.Patternfly.Components.Toaster
{
    public class ToastMessageModel
    {
        public ToastMessageModel(ToastMessage message, TimeSpan expiry)
        {
            this.Message = message;
            this.ExpireTime = DateTimeOffset.UtcNow.Add(expiry);
        }

        public ToastMessage Message { get; }
        public DateTimeOffset ExpireTime { get; }
        public bool IsDismissed { get; private set; }

        public void Dismiss()
		{
            this.IsDismissed = true;
		}
    }
}
