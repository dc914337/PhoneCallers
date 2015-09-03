using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using PhoneCallers.proxy;
using PhoneCallers.request;

namespace PhoneCallers.caller
{
    public class PhoneCaller
    {
        public List<CallRequest> Requests = new List<CallRequest>();
        Random rnd = new Random();

        public ProxyPool Proxies { get; set; }
        public RequestGenerator RequestGenerator { get; set; }
        public RequestTemplatesPool RequestTemplates { get; set; }

	    public PhoneCaller()
	    {
		    //serialization
	    }

        public PhoneCaller(ProxyPool proxies, RequestGenerator requestGenerator)
        {
            Proxies = proxies;
            RequestGenerator = requestGenerator;
        }

        public void AddRequest(String phone, int count)
        {
            Requests.Add(new CallRequest() { Phone = phone, Count = count });
        }

        public void SendNextRequest()
        {
            var request = RequestGenerator.GetRequest(RequestTemplates.GetTemplate(), getRandomCallRequest().Phone);

        }

        private CallRequest getRandomCallRequest()
        {
            var availableRequests = Requests.Where(a => a.Count > 0).ToArray();
            return availableRequests[rnd.Next(0, availableRequests.Length)];
        }

    }
}
