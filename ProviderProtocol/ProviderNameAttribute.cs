using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProviderProtocol
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
   public sealed class ProviderNameAttribute : Attribute
    {
        public string ProviderName { get; private set; }
        public ProviderNameAttribute(string providerName)
        {
            ProviderName = providerName;
        }


    }
}
