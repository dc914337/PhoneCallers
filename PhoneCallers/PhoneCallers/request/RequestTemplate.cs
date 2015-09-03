using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneCallers.request
{
	public class RequestTemplate
    {
        public String Url { get; set; }
        public Dictionary<String, String> Arguments { get; set; }
        public RequestType Type { get; set; }

        public DateTime LastUsed { get; set; }
        public int TimesUsed { get; set; }
    }
}
