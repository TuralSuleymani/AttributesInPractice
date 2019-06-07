using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProviderProtocol
{
    public enum EventType
    {
        Click,
        DblClick,
        MouseMove
    }


    [AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
   public sealed class ProviderOperationAttribute : Attribute
    {
       public EventType EventType { get; private set; }
        // This is a positional argument
        public ProviderOperationAttribute(EventType eventType)
        {
            EventType = eventType;
        }
    }
}
