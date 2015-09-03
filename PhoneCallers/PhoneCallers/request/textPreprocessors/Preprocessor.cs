using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PhoneCallers.request.textPreprocessors
{
    [XmlInclude(typeof(NamePreprocessor))]
    [XmlInclude(typeof(RandomNumberPreprocessor))]
    public abstract class Preprocessor
    {
        public abstract void ProcessRequest(Request request);
    }
}
