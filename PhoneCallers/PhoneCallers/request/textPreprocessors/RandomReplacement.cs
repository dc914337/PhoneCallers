using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneCallers.request.textPreprocessors
{
	public abstract class RandomReplacement : Preprocessor
    {
        public abstract void ProcessRequest(Request request);

    }
}
