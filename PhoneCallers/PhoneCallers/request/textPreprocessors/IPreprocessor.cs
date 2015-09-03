using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneCallers.request.textPreprocessors
{
    public interface IPreprocessor
    {
        void ProcessRequest(Request request);
    }
}
