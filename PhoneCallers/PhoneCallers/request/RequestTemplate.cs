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
        public List<Argument> Arguments { get; set; }
        public RequestType Type { get; set; }

        public DateTime LastUsed { get; set; }
        public int TimesUsed { get; set; }
    }

    public class Argument
    {
        public String Key { get; set; }
        public String Value { get; set; }

        public Argument()
        {
            //serialization
        }

        public Argument(string key, string value)
        {
            Key = key;
            Value = value;
        }
    }
}
