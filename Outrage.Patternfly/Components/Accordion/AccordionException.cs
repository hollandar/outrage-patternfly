using System;

namespace Outrage.Patternfly.Components.Accordion
{
    [Serializable]
    public class AccordionException: Exception
    {
        public AccordionException(string message) : base(message)
        {
        }

        public AccordionException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected AccordionException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext): base(serializationInfo, streamingContext)
        {
            
        }
    }
}
