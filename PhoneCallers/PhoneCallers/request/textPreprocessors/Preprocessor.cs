using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PhoneCallers.request.textPreprocessors
{
    [XmlInclude(typeof(RandomTextPreprocessor))]
    [XmlInclude(typeof(RandomNumberPreprocessor))]

   
    public  class Preprocessor
    {
        public String ReplaceString { get; set; }

        public void ReplaceAll(Request request, String replacement)
        {
            var keys = request.Arguments.Keys;
            foreach (var key in keys)
            {
                String value = request.Arguments[key];
                String changedValue = value.Replace(ReplaceString, replacement);
                request.Arguments[key] = changedValue;
            }
        }



    }
}
