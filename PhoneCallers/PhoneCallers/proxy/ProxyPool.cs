using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneCallers.proxy
{
    class ProxyPool
    {
        public List<Proxy> Proxies { get; set; }

        public Proxy GetRandomProxy()
        {
            return Proxies[0];
        }
        
    }
}
