using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PhoneCallers.request.textPreprocessors
{
    [XmlInclude(typeof(RandomTextPreprocessor))]
    [XmlInclude(typeof(RandomNumberPreprocessor))]
    public abstract class RandomReplacement : Preprocessor
    {
        public abstract void ProcessRequest(Request request);

    }
}
