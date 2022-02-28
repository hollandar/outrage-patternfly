using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Outrage.Patternfly.Components.Modal
{
    public class ActionModalException : Exception
    {
        public ActionModalException()
        {
        }

        public ActionModalException(string? message) : base(message)
        {
        }

        public ActionModalException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected ActionModalException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
