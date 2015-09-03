using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneCallers.request.textPreprocessors
{
    public class RandomTextPreprocessor : RandomReplacement
    {
        public List<String> RandomList { get; set; }


        public override void ProcessRequest(Request request)
        {
            throw new NotImplementedException();
        }
    }
}
