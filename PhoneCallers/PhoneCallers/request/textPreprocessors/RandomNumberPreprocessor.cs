﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneCallers.request.textPreprocessors
{
    public class RandomNumberPreprocessor : RandomReplacement
    {
        public int MinNumber { get; set; }
        public int MaxNumber { get; set; }

        public override void ProcessRequest(Request request)
        {
            throw new NotImplementedException();
        }
    }
}
