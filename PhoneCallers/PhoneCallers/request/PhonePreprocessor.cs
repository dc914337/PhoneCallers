using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneCallers.request.textPreprocessors;

namespace PhoneCallers.request
{
    public class PhonePreprocessor : Preprocessor
    {
        //new public String ReplaceString = "{phone}";

        public PhonePreprocessor()
        {

        }

        public void ProcessRequest(Request request, String phone)
        {
            ReplaceAll(request, phone);
        }

    }
}
