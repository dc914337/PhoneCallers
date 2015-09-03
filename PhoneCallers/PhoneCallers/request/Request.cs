using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneCallers.request
{
    public class Request
    {
        public Dictionary<String, String> Arguments { get; set; }
        public RequestTemplate Template { get; set; }

        public Request(RequestTemplate template)
        {
            Template = template;
            CopyArgsFromTemplate();
        }


        private void CopyArgsFromTemplate()
        {
            Arguments = new Dictionary<string, string>();
            foreach (var argument in Template.Arguments)
            {
                Arguments.Add(argument.Key, argument.Value);
            }

        }
    }
}
