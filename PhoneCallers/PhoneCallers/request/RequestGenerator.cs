using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneCallers.cfg;
using PhoneCallers.proxy;
using PhoneCallers.request.textPreprocessors;

namespace PhoneCallers.request
{
    class RequestGenerator
    {
        public List<IPreprocessor> Preprocessors { get; set; }
        public PhonePreprocessor PhonePreprocessor { get; set; }


        public Request GetRequest(RequestTemplate template, String phone)
        {
            Request resultRequest = new Request(template);
            foreach (var preprocessor in Preprocessors)
            {
                preprocessor.ProcessRequest(resultRequest);
            }

            PhonePreprocessor.ProcessRequest(resultRequest, phone);

            return resultRequest;
        }


    }
}
