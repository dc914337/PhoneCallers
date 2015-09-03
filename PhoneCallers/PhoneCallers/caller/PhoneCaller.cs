using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using PhoneCallers.proxy;
using PhoneCallers.request;
using PhoneCallers.request.textPreprocessors;

namespace PhoneCallers.caller
{
    [XmlRoot]
    public class PhoneCaller
    {
        [XmlIgnore]
        public List<CallRequest> Requests = new List<CallRequest>();

        Random _rnd = new Random();
        public ProxyPool Proxies { get; set; }
        public RequestGenerator RequestGenerator { get; set; }
        public RequestTemplatesPool RequestTemplates { get; set; }

        public PhoneCaller()
        {
            //serialization
        }

        public PhoneCaller(ProxyPool proxies, RequestGenerator requestGenerator, RequestTemplatesPool templatesPool)
        {
            Proxies = proxies;
            RequestGenerator = requestGenerator;
            RequestTemplates = templatesPool;
        }

        public void AddRequest(String phone, int count)
        {
            Requests.Add(new CallRequest() { Phone = phone, Count = count });
        }

        public void SendNextRequest()
        {
            var request = RequestGenerator.GetRequest(RequestTemplates.GetTemplate(), GetRandomCallRequest().Phone);

        }

        private CallRequest GetRandomCallRequest()
        {
            var availableRequests = Requests.Where(a => a.Count > 0).ToArray();
            return availableRequests[_rnd.Next(0, availableRequests.Length)];
        }

    }
}
