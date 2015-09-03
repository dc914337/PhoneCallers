using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneCallers.request
{
	public class RequestTemplatesPool
    {

        public List<RequestTemplate> RequestTemplates { get; set; }

        public RequestTemplate GetTemplate()
        {
            return RequestTemplates[0];
        }
    }


}
